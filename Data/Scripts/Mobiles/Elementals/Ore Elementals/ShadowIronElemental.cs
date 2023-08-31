using System;
using Server;
using Server.Items;
using Server.Misc;

namespace Server.Mobiles
{
    [CorpseName("an elemental corpse")]
    public class ShadowIronElemental : BaseCreature
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
        public ShadowIronElemental()
            : this(2) { }

        [Constructable]
        public ShadowIronElemental(int oreAmount)
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a shadow iron elemental";
            Body = Utility.RandomList(14, 446, 974);
            Hue = MaterialInfo.GetMaterialColor("shadow iron", "monster", 0);
            BaseSoundID = 268;

            SetStr(226, 255);
            SetDex(126, 145);
            SetInt(71, 92);

            SetHits(136, 153);

            SetDamage(9, 16);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 30, 40);
            SetResistance(ResistanceType.Fire, 30, 40);
            SetResistance(ResistanceType.Cold, 20, 30);
            SetResistance(ResistanceType.Poison, 10, 20);
            SetResistance(ResistanceType.Energy, 30, 40);

            SetSkill(SkillName.MagicResist, 50.1, 95.0);
            SetSkill(SkillName.Tactics, 60.1, 100.0);
            SetSkill(SkillName.FistFighting, 60.1, 100.0);

            Fame = 4500;
            Karma = -4500;

            VirtualArmor = 23;

            Item ore = new ShadowIronOre(oreAmount);
            ore.ItemID = 0x19B9;
            PackItem(ore);
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
            AddLoot(LootPack.Gems, 2);
        }

        public override bool AutoDispel
        {
            get { return true; }
        }
        public override bool BleedImmune
        {
            get { return true; }
        }
        public override int TreasureMapLevel
        {
            get { return 1; }
        }
        public override Poison PoisonImmune
        {
            get { return Poison.Deadly; }
        }
        public override bool BreathImmune
        {
            get { return true; }
        }

        public override void AlterMeleeDamageFrom(Mobile from, ref int damage)
        {
            if (from is BaseCreature)
            {
                BaseCreature bc = (BaseCreature)from;

                if (bc.Controlled || bc.BardTarget == this)
                    damage = 0; // Immune to pets and provoked creatures
            }
        }

        public override void AlterDamageScalarFrom(Mobile caster, ref double scalar)
        {
            scalar = 0.0; // Immune to magic
        }

        public override void AlterSpellDamageFrom(Mobile from, ref int damage)
        {
            damage = 0;
        }

        public ShadowIronElemental(Serial serial)
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
