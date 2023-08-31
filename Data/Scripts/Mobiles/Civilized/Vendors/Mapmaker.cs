using System;
using System.Collections.Generic;
using Server;
using Server.Targeting;
using Server.Items;
using Server.Network;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Mobiles;

namespace Server.Mobiles
{
    public class Mapmaker : BaseVendor
    {
        private List<SBInfo> m_SBInfos = new List<SBInfo>();
        protected override List<SBInfo> SBInfos
        {
            get { return m_SBInfos; }
        }

        public override NpcGuild NpcGuild
        {
            get { return NpcGuild.CartographersGuild; }
        }

        [Constructable]
        public Mapmaker()
            : base("the mapmaker")
        {
            SetSkill(SkillName.Cartography, 90.0, 100.0);
        }

        public override void InitSBInfo()
        {
            m_SBInfos.Add(new RSScrolls());
            m_SBInfos.Add(new SBMapmaker());
            m_SBInfos.Add(new SBBuyArtifacts());
        }

        ///////////////////////////////////////////////////////////////////////////
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new SpeechGumpEntry(from, this));
        }

        public class SpeechGumpEntry : ContextMenuEntry
        {
            private Mobile m_Mobile;
            private Mobile m_Giver;

            public SpeechGumpEntry(Mobile from, Mobile giver)
                : base(6146, 3)
            {
                m_Mobile = from;
                m_Giver = giver;
            }

            public override void OnClick()
            {
                if (!(m_Mobile is PlayerMobile))
                    return;

                PlayerMobile mobile = (PlayerMobile)m_Mobile;
                {
                    if (!mobile.HasGump(typeof(SpeechGump)))
                    {
                        Server.Misc.IntelligentAction.SayHey(m_Giver);
                        mobile.SendGump(
                            new SpeechGump(
                                mobile,
                                "X Marks The Spot",
                                SpeechFunctions.SpeechText(m_Giver, m_Mobile, "Mapmaker")
                            )
                        );
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////

        private class FixEntry : ContextMenuEntry
        {
            private Mapmaker m_Mapmaker;
            private Mobile m_From;

            public FixEntry(Mapmaker Mapmaker, Mobile from)
                : base(6120, 12)
            {
                m_Mapmaker = Mapmaker;
                m_From = from;
            }

            public override void OnClick()
            {
                m_Mapmaker.BeginRepair(m_From);
            }
        }

        public override void AddCustomContextEntries(Mobile from, List<ContextMenuEntry> list)
        {
            if (from.Alive && !from.Blessed)
            {
                list.Add(new FixEntry(this, from));
            }

            base.AddCustomContextEntries(from, list);
        }

        public void BeginRepair(Mobile from)
        {
            int money = 1000;

            double w = money * (MyServerSettings.GetGoldCutRate() * .01);
            money = (int)w;

            if (Deleted || !from.Alive)
                return;

            int nCost = money;

            if (BeggingPose(from) > 0) // LET US SEE IF THEY ARE BEGGING
            {
                nCost = nCost - (int)((from.Skills[SkillName.Begging].Value * 0.005) * nCost);
                if (nCost < 1)
                {
                    nCost = 1;
                }
                SayTo(
                    from,
                    "Since you are begging, do you still want me to decipher a treasure map for you, it will only cost "
                        + nCost.ToString()
                        + " gold per level of the map?"
                );
            }
            else
            {
                SayTo(
                    from,
                    "If you want me to decipher a treasure map for you, it will cost "
                        + nCost.ToString()
                        + " gold per level of the map"
                );
            }

            from.Target = new RepairTarget(this);
        }

        private class RepairTarget : Target
        {
            private Mapmaker m_Mapmaker;

            public RepairTarget(Mapmaker Mapmaker)
                : base(12, false, TargetFlags.None)
            {
                m_Mapmaker = Mapmaker;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                int money = 1000;

                double w = money * (MyServerSettings.GetGoldCutRate() * .01);
                money = (int)w;

                if (targeted is TreasureMap && from.Backpack != null)
                {
                    TreasureMap tmap = targeted as TreasureMap;
                    Container pack = from.Backpack;
                    int toConsume = tmap.Level * money;

                    if (BeggingPose(from) > 0) // LET US SEE IF THEY ARE BEGGING
                    {
                        toConsume =
                            toConsume
                            - (int)((from.Skills[SkillName.Begging].Value * 0.005) * toConsume);
                    }

                    if (toConsume == 0)
                        return;

                    if (tmap.Decoder != null)
                    {
                        m_Mapmaker.SayTo(from, "That map has already been deciphered.");
                    }
                    else if (pack.ConsumeTotal(typeof(Gold), toConsume))
                    {
                        if (BeggingPose(from) > 0)
                        {
                            Titles.AwardKarma(from, -BeggingKarma(from), true);
                        } // DO ANY KARMA LOSS
                        if (tmap.Level == 1)
                        {
                            m_Mapmaker.SayTo(from, "This map was really quite simple.");
                        }
                        else if (tmap.Level == 2)
                        {
                            m_Mapmaker.SayTo(from, "Seemed pretty easy...so here it is.");
                        }
                        else if (tmap.Level == 3)
                        {
                            m_Mapmaker.SayTo(from, "This map was a bit of a challenge.");
                        }
                        else if (tmap.Level == 4)
                        {
                            m_Mapmaker.SayTo(from, "Whoever drew this map, did not want it found.");
                        }
                        else if (tmap.Level == 5)
                        {
                            m_Mapmaker.SayTo(from, "This took more research than normal.");
                        }
                        else
                        {
                            m_Mapmaker.SayTo(
                                from,
                                "With the ancient writings and riddles, this map should now lead you there."
                            );
                        }

                        from.SendMessage(String.Format("You pay {0} gold.", toConsume));
                        Effects.PlaySound(from.Location, from.Map, 0x249);
                        tmap.Decoder = from;
                    }
                    else
                    {
                        m_Mapmaker.SayTo(
                            from,
                            "It would cost you {0} gold for me to decipher that map.",
                            toConsume
                        );
                        from.SendMessage("You do not have enough gold.");
                    }
                }
                else
                {
                    m_Mapmaker.SayTo(from, "That does not need my services.");
                }
            }
        }

        public Mapmaker(Serial serial)
            : base(serial) { }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}
