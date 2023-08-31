using System;
using Server;

namespace Server.Items
{
    public class CapOfFortune : LeatherCap
    {
        public override int InitMinHits
        {
            get { return 80; }
        }
        public override int InitMaxHits
        {
            get { return 160; }
        }

        public override int LabelNumber
        {
            get { return 1061098; }
        } // Cap of Fortune

        [Constructable]
        public CapOfFortune()
        {
            Name = "Cap of Fortune";
            Hue = 0x501;
            Attributes.Luck = 200;
            Attributes.DefendChance = 15;
            Attributes.LowerRegCost = 40;
            ArmorAttributes.MageArmor = 1;
        }

        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);
            list.Add(1070722, "Artefact");
        }

        public CapOfFortune(Serial serial)
            : base(serial) { }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}
