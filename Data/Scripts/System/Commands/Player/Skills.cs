using System;
using Server;
using Server.Items;
using Server.Network;
using Server.Commands;

namespace Server.Gumps
{
    public class NewSkillsGump : Gump
    {
        public int m_Origin;

        public static void Initialize()
        {
            CommandSystem.Register(
                "skill",
                AccessLevel.Player,
                new CommandEventHandler(NewSkillsGump_OnCommand)
            );
        }

        [Usage("skill")]
        [Description("Shows the player the definition of the skills in the game.")]
        public static void NewSkillsGump_OnCommand(CommandEventArgs e)
        {
            e.Mobile.SendGump(new NewSkillsGump(e.Mobile, 0));
        }

        public NewSkillsGump(Mobile from, int origin)
            : base(50, 50)
        {
            m_Origin = origin;
            string color = "#ddbc4b";
            from.SendSound(0x4A);

            this.Closable = true;
            this.Disposable = true;
            this.Dragable = true;
            this.Resizable = false;

            AddPage(0);

            AddImage(0, 0, 9546, Server.Misc.PlayerSettings.GetGumpHue(from));
            AddHtml(
                14,
                14,
                400,
                20,
                @"<BODY><BASEFONT Color=" + color + ">SKILL DESCRIPTIONS</BASEFONT></BODY>",
                (bool)false,
                (bool)false
            );
            AddButton(867, 10, 4017, 4017, 0, GumpButtonType.Reply, 0);

            string text = "";
            text =
                text
                + "Alchemy - This will need a mortar, pestle, empty bottle, and some reagents. A potion keg can hold many bottles of potions. Double clicking the mortar and pestle will start you on your way.<BR><BR>";
            text =
                text
                + "Anatomy - This will increase as you simply fight and heal with bandages. It allows for better damage and extra healing.<BR><BR>";
            text =
                text
                + "Arms Lore - This allows some crafters to make better weapons and armor. You may also find armor or weapons that are unidentifed. using this skill on them may identify them. You can identify weapons and armor to practice this skill, but they can only each be identified once. If you find some decorative armor or weapons, you can sometimes tell what you can get for it, and from whom. Again, these are decorative items and not something you would be able to use. If you determine that something like this does have value, give the item to the merchant you determined and they will give you some gold for it. Just hand it to them or keep it to decorate your home. If you master your mercantile skill, you will get double the price for rare items like these. If you want to have a chance for better weapon damage, this skill can help that as well.<BR><BR>";
            text =
                text
                + "Begging - This may get you a couple of gold if you use this skill on one of the many townsfolk. You can also target yourself for begging which will change your demeanor to 'begging'. While using this demeanor, townsfolk may do some services cheaper for you such as repairs, identification, and magic item charges. They will also be willing to buy your items and relics at a higher price. If you are really skilled at begging, you could convince opponents to stopping their attacks on you. Every time you are successful with this skill, you will lose a bit of karma. You will also lose fame if you cowardly convince one from attacking you.<BR><BR>";
            text =
                text
                + "Blacksmithing - This allows you to make weapons and armor with various types of metals. You will need ingots of metal, a blacksmith hammer, a forge, and an anvil to get started.<BR><BR>";
            text =
                text
                + "Bludgeoning - This is a weapon skill that focuses on items such as hammers, clubs, staffs, and maces. The more you use such weapons, the better you get at hitting opponents with them.<BR><BR>";
            text =
                text
                + "Bowcrafting - This allows you to make bows, crossbows, arrows, and bolts. You need a bowcrafting kit to get started, along with wood and possibly feathers. Those that are proficient in this skill also gain an advantage when using bows or crossbows.<BR><BR>";
            text =
                text
                + "Bushido - This is the main skill of the Samurai, and embodies the very essence of honorable combat. With it and the Book of Bushido (purchased from a monk), the Samurai can perform a variety of special abilities that mostly are defensive in nature...but can be used to quickly and honorably defeat the toughest of opponents. This skill also gives you an advantage when using pole arms, axes, and other slashing weapons.<BR><BR>";
            text =
                text
                + "Camping - This is used to logout safely when out in the wilderness with a bedroll. You can use a bladed weapon on a tree branch to get kindling, allowing you to start a fire and cook food. using a small tent, you can quickly build a secure area to rest for a bit...even with nearby enemies. With a camping tent, one good at camping may setup a tent and rest in complete safety. Those that become grandmasters in this skill, are able to use a hitching post to stable pets at their home. The better you are at this skill, the more resilient you are with hunger and thirst. This gives you the ability to travel longer without food and drink. Bedrolls and kindling can be used in areas where you feel safe and wish to rest. As long as you are not terribly hungry or thirst, your stamina and health will recover much more quickly. Kindling can only be used once as it will burn away when ignited. Bedrolls can be rolled back up and taken with you. Having both a bedroll and campfire set will double your recovery, but only for the one that actually owns the bedroll.<BR><BR>";
            text =
                text
                + "Carpentry - This allows you to make furniture, staves, wooden shields, crates, etc. You need a carpentry tool (like a saw) to get started, along with wood.<BR><BR>";
            text =
                text
                + "Cartography - This skill allows you to map the man lands you explore. Decoding treasure maps is also done with cartography. In order to make maps, you will need a map makers pen and blank scrolls. Maps can help you navigate this strange world, and sea charts can help you travel the high seas much easier. Most cartographers will tell you that the most treasure gained is from a well found treasure chest.<BR><BR>";
            text =
                text
                + "Cooking - If you want to be able to cook various types of food, this is the trade to take. You will need something like a frying pan, and a stove or fire, to get started. Those good at cooking have a chance to increase the amount when identifying reagents with tasting identification. Those proficient in this skill, also have a chance to identify some potions of a better quality. So one that would have normally identified a healing potion, as an example, would instead have identified a greater healing potion. Elixirs and mixtures have a greater effect when one is good at this skill.<BR><BR>";
            text =
                text
                + "Discordance - With a musical instrument, a bard is able to play a song that will cause an opponent to become less of a threat in battle by lowering their defenses and abilties. In order to be good with this skill, you must also master Musicianship.<BR><BR>";
            text =
                text
                + "Druidism - This allows you to know the attributes of creatures and helps in how many pets you can stable or control. Use this skill directly on tamed creatures to improve it. This skill, along with veterinary, also allows you to create druidic herbalism potions. When healing creatures with veterinary, druidism also helps.<BR><BR>";
            text =
                text
                + "Elementalism - Being an elemental form of magic, it draws from such forces to unleash spells appropriate to the elements. Unlike other forms of magic, elementalism only requires the intellect and mana of the caster, and thus do not require any form of reagents. Those that practice elementalism can never dabble in magery or necromancy, as they interfere with each other. The same is said for necromancers and mages, as they can never work with elementalism. Elementalists only have 32 spells as opposed to mages with their libraries of 64 spells. Those skilled in elementalism also gain a combat benefit with using staves and wands that you club with or fire magic beams, and scepter weapons. You must find an elementalist that will train you in this craft and sell you an elemental spellbook.<BR><BR>";
            text =
                text
                + "Fencing - This is a weapon skill that focuses on items such as daggers and spears. The more you use such weapons, the better you get at hitting opponents with them.<BR><BR>";
            text =
                text
                + "Fist Fighting - For those that decide to not use weapons, and instead enhance the power of their bodies, this skill will allow one to land deadly punches. Find a pair of nice pugilist gloves and you may be able to best a sword fighter in combat. Mages often learn this combat skill as it leaves their hands free to cast spells. Those good with this skill are those that choose to hone their bodies and can gain a restoration benefit when spiritualism.<BR><BR>";
            text =
                text
                + "Focus - This helps regenerate mana and stamina more quickly. Stamina can help a warrior swing their weapon quicker, while mana helps spellcasters cast more spells. Mana is also used in some combat maneuvers.<BR><BR>";
            text =
                text
                + "Forensic Evaulation - To investigate who unlocked a chest, this skill can help you investigate that. The major use of this skill is the fascination with corpses and the anatomy of them. To determine who killed a discovered body, you would use this skill. If you train this skill up to at least 5, you will begin to get more resources off of creatures when carved (meaning more meat, feathers, wool, etc)...where the better your skill the more you may get. The anatomy skill may provide better results when skinning creatures. You can also dabble in witchery brewing, which allows one to make horrid potions that necromancers can use to further their dark causes. If you have a morbid need for treasure, get a grave shovel and dig up any grave you can find. Double click the shovel and target a tombstone to see what you can dig up. It may be a chest, relic, potion, or the obvious body part. Be weary of the rising dead...but spiritualism may keep them at bay. It is illegal to dig up graves, so don't get spotted doing so as it will get you reported as a criminal.<BR><BR>";
            text =
                text
                + "Healing - With the use of bandages, one may heal themselves...even during combat. One that is very good at this skill, along with anatomy, are able to even cure poisons. You can cut cloth with scissors to make your own bandages. If you have a 60 in both healing and anatomy, you can start to cure poisons. If you have an 80 in both healing and anatomy, you can resurrect others.<BR><BR>";
            text =
                text
                + "Herding - This skill is often used by shepherds and their wooden crooks, but those good at this skill is able to have even more tamed pets accompanying them. It also helps to master this skill as it provides more stable space for any tamed pets.<BR><BR>";
            text =
                text + "Hiding - This allows you to become virtually invisible to others.<BR><BR>";
            text =
                text
                + "Inscription - This skill uses a pen, blank scroll, and some reagents. You can make copies of spells from spellbooks you may have. You also get a bonus to your mercantile when trying to identify a scroll. If you find a coded message during your journey, these can often be decoded by one intelligent enough. Having a good skill in inscription could also reveal the message.<BR><BR>";
            text =
                text
                + "Knightship - This is the primary talent of any character calling themself a Knight. It allows a fighter to utilize a limited set of spells that would not be feasible with Magery. These spells include healing, curing of poison, improved strength, and holy magic damage. Knightship skills require a Book of Knightship, available from any Knight, and consumes mana as well tithing points. Their rate of success is determined by the Knightship skill, while the power and duration of their effects is based on karma. Thithing points are gained by donating gold at many ankh shrines, by single clicking the ankh shrine...you can choose to donate your gold. Legends tell of Death Knights following the path of Knightship, but in a much different way forgotten by most.<BR><BR>";
            text =
                text
                + "Lockpicking - If you have a box or chest that is locked, this skill will probably help you get in. You must either make some lockpicks or find a thief that sells them. Others may sell them as well.<BR><BR>";
            text =
                text
                + "Lumberjacking - Cutting trees in the forest will allow you to gather more wood. This wood can be used to make furniture, arrows, weapons, or armor if you possess carpentry skills. Double click an axe and then a tree to cut the wood from it. The better your lumberjacking skill, the better you can fight with axes.<BR><BR>";
            text =
                text
                + "Magery - A difficult skill to master as those who seek the power have a long road of knowledge they must traverse. Get a spellbook and search the land for hidden spells you may collect and one day become a powerful wizard. Be on the lookout for reagents, as you will need them to summon these magics. Those skilled in magery also gain a combat benefit with using staves, sceptres, non-spell-imbued wands, and scepters. Mages can never dabble in the spells of elementalism, as they interfere with each other.<BR><BR>";
            text =
                text
                + "Magic Resistance - This not only helps you resist magic used against you, but also enhances many of your other defenses. Some magic cannot be avoided however, but this skill will at least minimize the effects.<BR><BR>";
            text =
                text
                + "Marksmanship - This will improve the more you use the appropriate weapons, increasing damage and possibilities to hit with ranged weapons. These are weapons like bows, crossbows, wizard staves, some magic wands, and throwing gloves. You have the ability to throw daggers, stones, harpoons, darts, axes, or shurikens.<BR><BR>";
            text =
                text
                + "Mercantile - If you want to make more money selling items to vendors in town, this skill will allow you to persuade them. You will also come across artifacts, wands, and scrolls that can only be identified with this skill. If you have some unusual item, you can sometimes tell what you can get for it, and from whom. These are strange items that are usually decorative in nature, and not something you would be able to use. It could be artwork, banners, books, cloth, carpets, coins, srinks, furs, gems, gravestones, instruments, jewels, leather, orbs, paintings, reagents, rugs, scrolls, statues, tablets, or vases. If you determine that it does have value, give the item to the merchant you determined and they will give you some gold for it. Just hand it to them or keep it to decorate your home. If you master this skill, you will get double the price for rare items like these.<BR><BR>";
            text =
                text
                + "Mining - THis is a basic, and fairly essential skill for an aspiring blacksmith or, to a slightly lesser degree, tinker. To begin mining you will need tools, these can be either picks or shovels and can be used from the backpack, they do not need to be equipped. The better your skill, the better the chance to dig up rare ore. Some ores can only be mined in certain lands and regions. The better your mining skill, the better you can fight with maces, clubs, and hammers.<BR><BR>";
            text =
                text
                + "Necromancy - This is the study of dark magic. using the power of spiritualism, one may amplify this power to its maximum potential. Like wizards, necromancers need specific reagents to use such magic. You will also need to find a necromancer spellbook, along with the spells to put in it. Those skilled in necromancy also gain a combat benefit with using staves and wands that you club with or fire magic beams, and scepter weapons. You also need this skill if you intend on researching witchery brewing. Necromancers can never dabble in the spells of elementalism, as they interfere with each other.<BR><BR>";
            text =
                text
                + "Ninjitsu - Some of the stealithiest assassins have come from those proficient with this skill. One needs to seek out a monk and get a Book of Ninjitsu to begin down this secret path of attacking from the shadows. Ninjas are adept at combat so this skill enhances their ability to use any weapon or their bare hands. You can further your ninja abilities by seeking the knowledge of the shinobi.<BR><BR>";
            text =
                text
                + "Parrying - With a shield, one can get better at blocking blows entirely. Those who follow the path of the samurai will use this skill with a sword instead of a shield. You should find someone to train you a little bit in this skill, so you will know what you are doing.<BR><BR>";
            text =
                text
                + "Peacemaking - Bards are able to create music with instruments that will take the most violent opponent and make them stop their attacks to listen to the ballads. In order to be good with this skill, you must also master Musicianship.<BR><BR>";
            text =
                text
                + "Poisoning - With a steady hand, and a bottle of poison, one can make certain weapons deal sickening blows. One also becomes better resistant to poison with this skill, and some poison-type spells benefit from this proficiency. Poison can be found or made by alchemists, or you may find venom sacks on some creatures. If you have an empty bottle, and you use the venom sack, you may be able to extract it out. Some weapons have a infectious strike ability that allows others to hit enemies with poisoned weapons. Although infectious strikes lets you better strategize your poisoned weapon, those that are good with this skill do not need infectious strikes to use poison weapons. Simply poison your weapon and it will test your poisoning skill when you attack an opponent that can be poisoned. You will not waste poison on those that are immune, or those that are currently poisoned. Those good at this skill also have the ability to dump bottles of poison on the ground to infect those that walk over it.<BR><BR>";
            text =
                text
                + "Provocation - Bards are able to play musical instruments and cause havoc among others to fight each other. In order to be good with this skill, you must also master Musicianship.<BR><BR>";
            text =
                text
                + "Psychology - Mages learn to evaluate another's intelligence to increase the power of their damaging spells against them, as well as mental manipulation of others.<BR><BR>";
            text =
                text
                + "Remove Trap - Some containers are trapped, and this skill will allow you to disarm them. With this skill, you are often able to walk near dungeon traps without setting them off. There are hidden traps as well, but being good with this skill can disable them when you walk near them. This skill is also passively active when you open trapped containers, along with walking near dungeon traps.<BR><BR>";
            text =
                text
                + "Seafaring - To catch you next meal with a fishing pole is not the only use of this skill. One may take to the high seas and fish up special treasure as well. Only good fisherman may fish up trophy fish, which you use with a taxidermy kit to mount in your home. Also, any shipwrecks under the waves can only have one skilled in this...bring them to the surface. There are also rare fish to be caught, which fetch a high price. Those skilled in fishing also have a better chance in using harpoons than other ranged weapons. This skill can improve by fishing, turning in cargo, slaying pirates or sailors, selling exotic fish, killing creature out on the high seas, and using fishing nets. To learn more about fishing and the high seas, seek out the book titled 'Skulls and Shackles'.<BR><BR>";
            text =
                text
                + "Searching - To find stealthy or invisible beings, this skill helps with that. One may also avoid dungeon floor and wall traps with this skill, but only when actively searching. If a trap is nearby, it will show you the location to avoid, but only briefly. You may accidentally find lost or hidden treasure in a dungeon. You may stumble upon it, or actively search for it with this skill. Secret doors will be revealed as well. If you have night sight from a potion (night sight or eyes of the dead mixture), spell (night sight or heavenly light), or magic items you will have a chance to detect traps, hidden treasure, or secret doors when you either use this skill in the area or stumble over a hidden pile of treasure. Your night sight spot chance is 2% chance per item equipped with night sight attributes, as well as an additional 2% for a spell or potion effect that provides night sight.<BR><BR>";
            text =
                text
                + "Snooping - In order to begin Stealing from others, you need to be able to look in their packs for goods.<BR><BR>";
            text =
                text
                + "Spiritualism - This skill helps necromancers with extra power for their spells. You can also summon your own spiritual energy to heal your wounds and restore some stamina. Those with low karma can even channel the energy from corpses for a greater effect within themselves. Those that hone their bodies, with skills in fist fighting, will have an added benefit with bodily restoration.<BR><BR>";
            text =
                text
                + "Stealing - Things that don't belong to you can be acquired with this skill. Stealing gold from others, or stealing an artifact from an ancient dungeon, thieves make a living doing such things. To steal from other adventurers, one must find and join a Thieves Guild. You can steal coins and such from other creatures by standing next to them and attacking them, where you may automatically steal such items when giving the attack.<BR><BR>";
            text =
                text
                + "Stealth - Hiding is one thing, but walking around without being detected is what this skill can do. Why fight your way home when you can walk past your enemies? You will need a skill of 30 in Hiding and then your choice of armor must be light. Once you reach 60 or 65, wear some studded leather to improve further. When you finally reach 90 or 95, try wearing some ringmail and a close helmet to master the skill. <BR><BR>";
            text =
                text
                + "Swordsmanship - This is a weapon skill that focuses on items such as swords and axes. The more you use such weapons, the better you get at hitting opponents with them.<BR><BR>";
            text =
                text
                + "Tactics - Fighters fight, but those who want to be the best train their Tactics skill. This will allow you to do more damage with weapons.<BR><BR>";
            text =
                text
                + "Tailoring - using a sewing kit, one may make clothes and leather armor. You may also need cloth or leather to make things from.<BR><BR>";
            text =
                text
                + "Taming - This allows you to tame most creatures. The more you tame, the better you get at it. Along with druidism, herding, and veterinary allows you to potentially control more creatures.<BR><BR>";
            text =
                text
                + "Tasting - Used once by royalty to determine if food was poisoned, many adventurers use this skill to identify potions they may find. There are also many reagents that will be unidentified unless you taste them first. Old dirty water, stale bread, and dried beef found in dungeons may be hazardous to your health, but this skill will avoid such illnesses while still nourishing you. You may even get a better benefit from food and drink as well. Elixirs and mixtures have a greater effect when one is good at this skill.<BR><BR>";
            text =
                text
                + "Tinkering - This skill allows one to make many different types of tools and intricate items. If one wants to make jewelry, then this skill can accomplish that. Tinker tools are needed...along with metal ingots or wood.<BR><BR>";
            text =
                text
                + "Tracking - Hunters are proficient with this skill as it allows them to track their prey. With a good tracking skill, one may even track hidden or invisible creatures.<BR><BR>";
            text =
                text
                + "Veterinary - If one decides to become a Tamer, this skill will allow you to use bandages to heal your pets and even resurrect them. This skill is also required if one intends to explore druidic herbalism.<BR><BR>";

            AddHtml(
                17,
                49,
                875,
                726,
                @"<BODY><BASEFONT Color=" + color + ">" + text + "</BASEFONT></BODY>",
                (bool)false,
                (bool)true
            );
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;
            from.SendSound(0x4A);
            if (m_Origin > 0)
            {
                from.SendGump(new Server.Engines.Help.HelpGump(from, 1));
            }
        }
    }
}
