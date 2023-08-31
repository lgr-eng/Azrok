using System;
using Server;
using Server.Items;
using Server.Misc;

namespace Server.Mobiles
{
    [CorpseName("an elemental corpse")]
    public class BronzeElemental : BaseCreature
    {
        public override double DispelDifficulty
        {
            get { return 120.5; }
        }
        public override double DispelFocus
        {
            get { return 45.0; }
        }

        public override int BreathPhysicalDamage
        {
            get { return 100; }
        }
        public override int BreathFireDamage
        {
            get { return 0; }
        }
        public override int BreathColdDamage
        {
            get { return 0; }
        }
        public override int BreathPoisonDamage
        {
            get { return 0; }
        }
        public override int BreathEnergyDamage
        {
            get { return 0; }
        }
        public override int BreathEffectHue
        {
            get { return 0; }
        }
        public override int BreathEffectSound
        {
            get { return 0x65A; }
        }
        public override int BreathEffectItemID
        {
            get { return 0; }
        }
        public override bool ReacquireOnMovement
        {
            get { return !Controlled; }
        }
        public override bool HasBreath
        {
            get { return true; }
        }
        public override double BreathEffectDelay
        {
            get { return 0.1; }
        }

        public override void BreathDealDamage(Mobile target, int form)
        {
            base.BreathDealDamage(target, 29);
        }

        [Constructable]
        public BronzeElemental()
            : this(2) { }

        [Constructable]
        public BronzeElemental(int oreAmount)
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            // TODO: Gas attack
            Name = "a bronze elemental";
            Body = Utility.RandomList(14, 446, 974);
            Hue = MaterialInfo.GetMaterialColor("bronze", "monster", 0);
            BaseSoundID = 268;

            SetStr(226, 255);
            SetDex(126, 145);
            SetInt(71, 92);

            SetHits(136, 153);

            SetDamage(9, 16);

            SetDamageType(ResistanceType.Physical, 30);
            SetDamageType(ResistanceType.Fire, 70);

            SetResistance(ResistanceType.Physical, 30, 40);
            SetResistance(ResistanceType.Fire, 30, 40);
            SetResistance(ResistanceType.Cold, 10, 20);
            SetResistance(ResistanceType.Poison, 70, 80);
            SetResistance(ResistanceType.Energy, 20, 30);

            SetSkill(SkillName.MagicResist, 50.1, 95.0);
            SetSkill(SkillName.Tactics, 60.1, 100.0);
            SetSkill(SkillName.FistFighting, 60.1, 100.0);

            Fame = 5000;
            Karma = -5000;

            VirtualArmor = 29;

            Item ore = new BronzeOre(oreAmount);
            ore.ItemID = 0x19B9;
            PackItem(ore);
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
            AddLoot(LootPack.Gems, 2);
        }

        public override bool BleedImmune
        {
            get { return true; }
        }
        public override bool AutoDispel
        {
            get { return true; }
        }
        public override int TreasureMapLevel
        {
            get { return 1; }
        }

        public BronzeElemental(Serial serial)
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
