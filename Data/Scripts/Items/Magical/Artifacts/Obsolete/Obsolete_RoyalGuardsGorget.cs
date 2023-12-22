using System;
using Server.Items;
using Server.Network;
using Server.Targeting;

namespace Server.Items
{
    public class RoyalGuardsGorget : PlateGorget, IIslesDreadDyable
    {
        public override int InitMinHits
        {
            get { return 80; }
        }
        public override int InitMaxHits
        {
            get { return 160; }
        }

        public override int BaseColdResistance
        {
            get { return 12; }
        }
        public override int BaseEnergyResistance
        {
            get { return 12; }
        }
        public override int BasePhysicalResistance
        {
            get { return 15; }
        }
        public override int BasePoisonResistance
        {
            get { return 14; }
        }
        public override int BaseFireResistance
        {
            get { return 13; }
        }

        [Constructable]
        public RoyalGuardsGorget()
        {
            Name = "Royal Guardian's Gorget";
            Hue = 2956;
            ArmorAttributes.MageArmor = 1;
            ArmorAttributes.SelfRepair = 3;
            Attributes.AttackChance = 10;
            Attributes.BonusHits = 10;
            Attributes.LowerManaCost = 5;
        }

        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);
            list.Add(1070722, "Artefact");
        }

        public RoyalGuardsGorget(Serial serial)
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
