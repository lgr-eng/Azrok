using System;
using Server.Network;

namespace Server.Items
{
    [FlipableAttribute(0xC74, 0xC75)]
    public class HoneydewMelon : Food
    {
        [Constructable]
        public HoneydewMelon()
            : this(1) { }

        [Constructable]
        public HoneydewMelon(int amount)
            : base(amount, 0xC75)
        {
            this.Weight = 1.0;
            this.FillFactor = 2;
        }

        public HoneydewMelon(Serial serial)
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
