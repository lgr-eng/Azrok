using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
    public class GiftBroadsword : BaseGiftSword
    {
        public override WeaponAbility PrimaryAbility
        {
            get { return WeaponAbility.CrushingBlow; }
        }
        public override WeaponAbility SecondaryAbility
        {
            get { return WeaponAbility.ArmorIgnore; }
        }
        public override WeaponAbility ThirdAbility
        {
            get { return WeaponAbility.ForceOfNature; }
        }
        public override WeaponAbility FourthAbility
        {
            get { return WeaponAbility.ShadowInfectiousStrike; }
        }
        public override WeaponAbility FifthAbility
        {
            get { return WeaponAbility.DeathBlow; }
        }

        public override int AosStrengthReq
        {
            get { return 30; }
        }
        public override int AosMinDamage
        {
            get { return 14; }
        }
        public override int AosMaxDamage
        {
            get { return 15; }
        }
        public override int AosSpeed
        {
            get { return 33; }
        }
        public override float MlSpeed
        {
            get { return 3.25f; }
        }

        public override int OldStrengthReq
        {
            get { return 25; }
        }
        public override int OldMinDamage
        {
            get { return 5; }
        }
        public override int OldMaxDamage
        {
            get { return 29; }
        }
        public override int OldSpeed
        {
            get { return 45; }
        }

        public override int DefHitSound
        {
            get { return 0x237; }
        }
        public override int DefMissSound
        {
            get { return 0x23A; }
        }

        public override int InitMinHits
        {
            get { return 31; }
        }
        public override int InitMaxHits
        {
            get { return 100; }
        }

        [Constructable]
        public GiftBroadsword()
            : base(0xF5E)
        {
            Weight = 6.0;
            Name = "broadsword";
            ItemID = Utility.RandomList(0xF5E, 0xF5F, 0xF5E, 0x2AB0, 0x2AB1, 0x2AB4);
        }

        public GiftBroadsword(Serial serial)
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
