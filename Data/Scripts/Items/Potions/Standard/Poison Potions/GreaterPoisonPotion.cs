using System;
using System.Collections;
using Server;
using Server.Misc;
using Server.Mobiles;
using Server.Network;
using Server.Prompts;
using Server.Spells;
using Server.Targeting;

namespace Server.Items
{
    public class GreaterPoisonPotion : BasePoisonPotion
    {
        public override Poison Poison
        {
            get { return Poison.Greater; }
        }

        public override double MinPoisoningSkill
        {
            get { return 40.0; }
        }
        public override double MaxPoisoningSkill
        {
            get { return 80.0; }
        }

        [Constructable]
        public GreaterPoisonPotion()
            : base(PotionEffect.PoisonGreater)
        {
            Name = "greater poison potion";
            ItemID = 0x2601;
        }

        public GreaterPoisonPotion(Serial serial)
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
