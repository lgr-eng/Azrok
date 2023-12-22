using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Server;
using Server.Accounting;
using Server.Misc;
using Server.Mobiles;
using Server.Network;
using Server.Regions;

namespace Server.Items
{
    public class HenchmanMonsterItem : HenchmanItem
    {
        [Constructable]
        public HenchmanMonsterItem()
        {
            ItemID = 0x1F0B;
            Hue = 0xB5C;
            Name = "creature henchman";
        }

        public HenchmanMonsterItem(Serial serial)
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
