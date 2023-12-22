using System;
using System.Text;
using Server;
using Server.Items;
using Server.Misc;
using Server.Mobiles;
using Server.Network;

namespace Server.Items
{
    public class UnknownScroll : Item
    {
        public int ScrollLevel;
        public int ScrollType;
        public string ScrollOrigin;

        [CommandProperty(AccessLevel.Owner)]
        public int Scroll_Level
        {
            get { return ScrollLevel; }
            set
            {
                ScrollLevel = value;
                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.Owner)]
        public int Scroll_Type
        {
            get { return ScrollType; }
            set
            {
                ScrollType = value;
                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.Owner)]
        public string Scroll_Origin
        {
            get { return ScrollOrigin; }
            set
            {
                ScrollOrigin = value;
                InvalidateProperties();
            }
        }

        [Constructable]
        public UnknownScroll()
            : base(0x4CC4)
        {
            string sLanguage = "pixie";
            switch (Utility.RandomMinMax(0, 35))
            {
                case 0:
                    sLanguage = "balron";
                    break;
                case 1:
                    sLanguage = "pixie";
                    break;
                case 2:
                    sLanguage = "centaur";
                    break;
                case 3:
                    sLanguage = "demonic";
                    break;
                case 4:
                    sLanguage = "dragon";
                    break;
                case 5:
                    sLanguage = "dwarvish";
                    break;
                case 6:
                    sLanguage = "elven";
                    break;
                case 7:
                    sLanguage = "fey";
                    break;
                case 8:
                    sLanguage = "gargoyle";
                    break;
                case 9:
                    sLanguage = "cyclops";
                    break;
                case 10:
                    sLanguage = "gnoll";
                    break;
                case 11:
                    sLanguage = "goblin";
                    break;
                case 12:
                    sLanguage = "gremlin";
                    break;
                case 13:
                    sLanguage = "druidic";
                    break;
                case 14:
                    sLanguage = "tritun";
                    break;
                case 15:
                    sLanguage = "minotaur";
                    break;
                case 16:
                    sLanguage = "naga";
                    break;
                case 17:
                    sLanguage = "ogrish";
                    break;
                case 18:
                    sLanguage = "orkish";
                    break;
                case 19:
                    sLanguage = "sphinx";
                    break;
                case 20:
                    sLanguage = "treekin";
                    break;
                case 21:
                    sLanguage = "trollish";
                    break;
                case 22:
                    sLanguage = "undead";
                    break;
                case 23:
                    sLanguage = "vampire";
                    break;
                case 24:
                    sLanguage = "dark elf";
                    break;
                case 25:
                    sLanguage = "magic";
                    break;
                case 26:
                    sLanguage = "human";
                    break;
                case 27:
                    sLanguage = "symbolic";
                    break;
                case 28:
                    sLanguage = "runic";
                    break;
            }

            string sPart = "a ";
            switch (Utility.RandomMinMax(0, 5))
            {
                case 0:
                    sPart = "a strange ";
                    break;
                case 1:
                    sPart = "an odd ";
                    break;
                case 2:
                    sPart = "an ancient ";
                    break;
                case 3:
                    sPart = "a long dead ";
                    break;
                case 4:
                    sPart = "a cryptic ";
                    break;
                case 5:
                    sPart = "a mystical ";
                    break;
            }

            string sCalled = "a strange";
            switch (Utility.RandomMinMax(0, 6))
            {
                case 0:
                    sCalled = "an odd";
                    break;
                case 1:
                    sCalled = "an unusual";
                    break;
                case 2:
                    sCalled = "a bizarre";
                    break;
                case 3:
                    sCalled = "a curious";
                    break;
                case 4:
                    sCalled = "a peculiar";
                    break;
                case 5:
                    sCalled = "a strange";
                    break;
                case 6:
                    sCalled = "a weird";
                    break;
            }
            Name = sCalled + " magic scroll";

            ScrollOrigin = "written in " + sPart + sLanguage + " language";

            if (Utility.RandomMinMax(1, 500) == 1)
            {
                ScrollType = 4;
            }
            else if (Utility.RandomMinMax(1, 500) == 1)
            {
                ScrollType = 5;
            }
            else if (Utility.RandomMinMax(1, 1000) == 1)
            {
                ScrollType = 6;
            }
            else if (Utility.RandomMinMax(1, 4) == 1)
            {
                int subc = Utility.RandomMinMax(1, 5);
                if (subc > 3)
                {
                    ScrollType = 2;
                }
                else if (subc > 1)
                {
                    ScrollType = 7;
                }
                else
                {
                    ScrollType = 3;
                }
            }
            else
            {
                ScrollType = 1;
            }

            ScrollLevel = Utility.RandomMinMax(1, 6);

            ItemID = Utility.RandomList(0x4CC4, 0x4CC5);
            Hue = Utility.RandomColor(11);
            Weight = 1.0;
            Stackable = false;
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!Movable)
            {
                from.SendMessage("That cannot move so you cannot identify it.");
                return;
            }
            else if (
                !IsChildOf(from.Backpack) && Server.Misc.MyServerSettings.IdentifyItemsOnlyInPack()
            )
            {
                from.SendMessage("This must be in your backpack to identify.");
                return;
            }
            else if (!from.InRange(this.GetWorldLocation(), 3))
            {
                from.SendMessage("You will need to get closer to identify that.");
                return;
            }
            else
            {
                Server.Items.ItemIdentification.IDItem(from, this, this, false);
            }
        }

        public UnknownScroll(Serial serial)
            : base(serial) { }

        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);
            list.Add(1070722, ScrollOrigin);
            list.Add(1049644, "Unidentified"); // PARENTHESIS
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
            writer.Write(ScrollLevel);
            writer.Write(ScrollType);
            writer.Write(ScrollOrigin);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
            ScrollLevel = reader.ReadInt();
            ScrollType = reader.ReadInt();
            ScrollOrigin = reader.ReadString();

            if (ItemID != 0x4CC4 && ItemID != 0x4CC5)
            {
                ItemID = Utility.RandomList(0x4CC4, 0x4CC5);
            }
        }
    }
}
