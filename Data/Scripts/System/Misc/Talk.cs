using System;
using Server;
using Server.Misc;
using Server.Gumps;
using Server.Network;
using Server.Commands;
using Server.Items;
using System.Text;
using Server.Mobiles;
using System.Collections;
using Server.Commands.Generic;
using Server.Regions;

namespace Server.Gumps
{
    public class SpeechGump : Gump
    {
        public SpeechGump(Mobile from, string sTitle, string sText)
            : base(50, 50)
        {
            string color = "#d5a496";

            this.Closable = true;
            this.Disposable = true;
            this.Dragable = true;
            this.Resizable = false;

            AddPage(0);

            AddImage(0, 2, 9543, Server.Misc.PlayerSettings.GetGumpHue(from));
            AddHtml(
                12,
                15,
                341,
                20,
                @"<BODY><BASEFONT Color=" + color + ">" + sTitle + "</BASEFONT></BODY>",
                (bool)false,
                (bool)false
            );
            AddHtml(
                12,
                50,
                380,
                253,
                @"<BODY><BASEFONT Color=" + color + ">" + sText + "</BASEFONT></BODY>",
                (bool)false,
                (bool)true
            );
            AddButton(367, 12, 4017, 4017, 0, GumpButtonType.Reply, 0);
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;
            from.SendSound(0x4A);
        }
    }
}

namespace Server.Misc
{
    class SpeechFunctions
    {
        public static string SpeechText(Mobile m, Mobile from, string sConversation)
        {
            string sYourName = from.Name;
            string sMyName = m.Name;

            Server.Gumps.MyChat.speechText(sConversation, from);

            string sText = "";

            if (sConversation == "Ranger")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and I can teach you about surviving the land. Surviving the wilderness is often easier to those that can live by their wits and not the aid of magic. We rangers have no need for magical scrolls or spells of power. We know when to rest, and we know where to rest. We strategically place our camps to rest in complete safety. A well rested adventurer, is an adventurer that returns to tell their tales. If you wish to pursue this life of living off the land, you must practice in the skill of camping. With a bedroll, and a simple camp fire, you can rest safely for the night. You may also make use of small tents. These tents are useful when you find yourself in immediate danger. If you can build your tent fast enough, you can remain safe for a couple of minutes while you prepare yourself for the dangers outside. These types of tents can only be assembled outside, so don't try to use them within the dungeons and tombs.<br><br>Camping tents are what keep the best rangers going for long periods of time. It could be weeks before a ranger returns to a settlement, as camping tents can provide almost anything a ranger needs. For the skilled ranger, a camping tent can provide food and water along with the unlimited safety for rest. Those experts in camping, can build their camping tents and have even more comforts. Enough to draw in other adventurers that may provide you with some of their wares like food, drink, and survival gear. These camping tents can also allow you to organize your items from your bank box. The nicest part of camping tents, is that you can use them while underground. This allows for greater dungeon exploration as you can safely store your found treasure and not overburden yourself. I sometimes sell small tents and camping tents, but you may find them easier from provisioners.<br><br>You can use traps to help hunt for creatures. You can sometimes buy the plain trapping tools, but tinkers can usually make the best trapping tools since they can use metals that cause more damage than plain iron does. Simply use the tools and a trap will be placed at your feet. Although you can avoid your own trap, others may not be able to. The higher your trap removing skill, the more effective your trap will be. If you have trapping tools made from  more precious metals, it would be even more effective.<br><br>Safe travels.";
            }
            else if (sConversation == "Shipwright")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and I can teach you about sailing and navigating the high seas. When you are able to finally purchase your own ship, you will be given a deed from which you can have your ship built. Ships may only be placed in water and there must be some type of dock nearby. When you dry dock your ship, you must also be near a dock. When dry docked, you will get a small representation of that ship to carry with you for safe keeping. Take this to any outdoor water source and double click it, where you will then be asked to place it in the water. A key will be placed in your backpack and your bank box to lock and unlock the vessel. If you have recall magic, you can use the key to magically travel to your boat no matter where it is. Now if you own your own home, you may get a 'docking lantern' from me to place in your home. This also assumes that your home is built near a body of water. The 'docking lantern' must be secured in your home. This allows you to launch, or dry dock, a ship near that home. You can even set the security on the lantern so only certain people you trust can make use of its light.<br><br>You may paint your ship whatever color you want, but keep in mind that the entire ship will have the color you paint it. Use any method you would to dye items on your ship that is in your pack. When you place the ship in the water, it will have that color. I have seen some horrific looking ships because of this, but it does allow you to have a ghostly looking ship or even an evil dark ship on the high seas. No matter if on the water, or in your possession, the ship will maintain the color in which is it painted.<br><br>As for sailing the ship, you must be on the deck of your boat to pilot her. Double click the tillerman and a window will appear that will allow you to navigate the ship. You may place this window over your mini-map for better navigation. You will notice red diamonds on the different directionals. Select these to move the boat in that direction. Don't forget to raise the anchor first. This can be done on the wooden placard. There you can drop or raise the anchor. You can rename your ship to whatever you want. Lastly, you can set the speed of your ship to either full speed, or move alone a step at a time. On the placard, there are three triangle arrows. There is one on the left, one on the right, and one on the bottom. Selecting the left or right ones will turn your ship in that direction. Selecting the bottom one will make your vessel come about. There is a red flag attached to the placard. Selecting this will stop your ship. There is a gray tab on the right of the placard. Selecting this will switch this window from one map size to another. If you wish to dry dock your ship, make sure the hold is empty as well as the deck. While on shore, double click the tillerman and he will ask you if you wish to dry dock the ship.<br><br>If you have a sea chart from a cartographer, you can use it to plot a course. After you plot the course on the map, give it to the tillerman. Once he exclaims 'a map!', he will give it back to you and you can simply say 'start'. The tillerman will follow the course you set on the sea chart.<br><br>There are different sizes and styles of ship. The type you acquire matters little. The larger ships allow you to have more passengers, and the hold size greatly increases the bigger the ship. Some like to sail the world and flaunt their wealth. Others merely seek adventure on the high seas. A few seek only to relax and fish. Abandoned boats will only last about 30 rises of the sun before the hull rots and it sinks into the sea, so don't leave her alone that long without putting her in dry dock. Be careful out there no matter the reason. Pirates usually sail about and they take no prisoners. May the wind be at your back.";
            }
            else if (sConversation == "Banker")
            {
                sText =
                    "Welcome to our bank, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and if you need to have some currency converted, I can help you with that. Usually, merchants do not deal in anything other than gold coins. Adventurers often come across coins from the old days. Coins like copper and silver are not too uncommon when one is looking. We usually take the copper and silver, melt it down, and sell it to local blacksmiths. We will trade you 1 gold coin for every 5 silver coins you bring to us. We will also trade 1 gold coin for every 10 copper coins you bring us. This may sound unfair, but you will not find another way to part with those coins. Simply give us a stack of coins and we will convert it for you. You may also put the coins in your bank box, double click the stack, and they will be converted as well. If you happen to find piles of jewels, we will convert those for you as well since the local jeweler often comes by to barter for them. You will know when you find these as they are the size of most coins but vary in color. Don't mistake jewels for gems like diamonds and sapphires. Jewels are found in piles like coins. For every jewel you bring here, we will give you 2 gold for each.<br><br>We also deal in some types of stones and crystals you may stumble upon. Gold nuggets are something we can turn into coins for you, and we do not mean gold ore. Gold nuggets have a shimmering glow to them. You may also find gemstones, which are different than jewels or common stones like diamonds. We will give you 2 gold coins for each of your gemstones as we use that currency with some other kingdoms far away. Crystals are another form of currency that we sometimes use with beings from other planes of existence, so we are greatly interested in them since they are very hard to find. Some claim they have mined for them in the Mines of Morinia, but nobody seems to return to tell the truth of such tales. They are shimmering red in color and we will gladly give you 5 gold for each crystal you find.<br><br>This may sound a little odd, but there are coins we are seeing that are bright green in color. Adventurers claim they find them in some ancient castle that fell from the sky centuries ago. If you find these coins, we will gladly give you 3 gold for each one you find. They are quite rare so the chances of you finding them are unlikely. One more thing, do you need a safe for your home? We sell safes that let you access your bank account from your home. They cost a great amount of gold, but we sell them nonetheless.";
            }
            else if (sConversation == "Weaponsmith")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and if you need your weapon repaired you can hire me to do so. I must apologize though, as I do not fixed ranged weapons. Perhaps a bowyer could help you out with any ranged weapons you need repaired.";
            }
            else if (sConversation == "Variety")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and if you happen to come across anything unusual in your adventures, I may want to have a look at it. I can pay well if you find rare items like vases, paintings, statues, banners, or carpets. There are other rare items you may discover like unusual reagents that an alchemist may want, strange armor or shields that armorers may seek, unusual decorative weapons that a weaponsmith would show interest, or rare books that scribes would love to read. You could perhaps find ancient scrolls of strange spells that you could never decipher, but a mage will pay greatly for. Stone tablets of long forgotten text may be sought by sages. Special cloth could be traded to a tailor or incredible leather would be interesting to a leather worker. Finding piles of strange furs would be something that a furtrader would desire, where bards often love adding ancient instruments to their collection. Even finding a finely ages keg of ale would be greatly accepted by the local tavern. Whenever you find these items, you can either keep it for yourself or give it to one of us local merchants that would want the item. You will be given gold commensurate for the value and rarity of the item. Those that are skilled merchants or arms dealers would often get more gold than the average adventurer.";
                if (Server.Items.MuseumBook.IsEnabled())
                {
                    sText =
                        sText
                        + "<br><br>I also seek a seasoned adventurer to catalog a particular number of antiques for my museum that have yet to be proven to exist. There are 60 of these antiques in total and they may be out there somewhere. If you are interested in helping me, and have discovered the nine known lands, then hand me 500 gold coins so I could scribe a copy of the book you will need to take with you. Bring the book back to me when you find all of the antiques and I will reward you with "
                        + MuseumBook.QuestValue()
                        + " gold. I would also trade gold for the antiques you find, as each has a value placed on them. Just give me the item if you choose and I will hand you the gold for it.";
                }
            }
            else if (sConversation == "Thief")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", but that is known only to a few. If you come across a chest with a stubborn lock, you could hire me to remove it. If you are more interested in the skills I have, maybe The Art of Tomb Raiding book can help you on your way. Those skilled in stealing can take many things from dungeons that no one else can. You may find it worthwhile.<br><br>Teaching yourself how to stealth around can be quite the test of skill, as long as you achieve a 30.0 in hiding. In order to get more proficient, you need to attempt to stealth in heavier armor as you get better with the skill. Here are some examples of items you can wear for the corresponding skill range you are currently trying to achieve:<br><br>30.0-57.4:<br>   - Leather Gorget<br>   - Leather Gloves<br><br>57.4-65.0:<br>   - Ringmail Gloves<br>   - Leather Sleeves<br>   - Leather Gorget<br><br>65.0-84.5:<br>   - Ringmail Gloves<br>   - Ringmail Sleeves<br>   - Leather Gorget<br><br>84.5-95.0:<br>   - Ringmail Gloves<br>   - Ringmail Leggings<br>   - Leather Tunic<br>   - Studded Sleeves<br>   - Studded Gorget<br><br>95.0-100:<br>   - Leather Leggings<br>   - Chainmail Tunic<br>   - Studded Gorget<br>   - Leather Cap<br><br>100-120:<br>   - Chainmail Tunic<br>   - Ringmail Sleeves<br>   - Platemail Gorget<br><br>You can use traps to help catch unsuspecting travelers off guard. You can sometimes buy the plain trapping tools, but tinkers can usually make the best trapping tools since they can use metals that cause more damage than plain iron does. Simply use the tools and a trap will be placed at your feet. Although you can avoid your own trap, others may not be able to. The higher your trap removing skill, the more effective your trap will be. If you have trapping tools made from more precious metals, it would be even more effective.<br><br>Now let me tell you about the towns and cities. We wouldn't be a thieves guild without lightening the purses of the local citizens. This is a tricky venture, but the merchants do carry gold in their pockets and coffers. You just need to snoop the merchant or coffer to see if there is gold to steal. If the merchant has gold, you can try to steal it. If the coffer has gold, then use your stealing skill on the coffer itself. Try not to get noticed because you may have the guards called on you. You can steal coins and such from other creatures by standing next to them and attacking them, where you may automatically steal such items when giving the attack.<br><br>Lastly, if you want to do some shady jobs for our more prominent clientele, then whisper to my guildmaster and they will give you a job to undertake. These are not limited to guild members, as any able thief can do them. You will be given a message of what you need to steal and where it can be found. These are unusual tasks because no one wants to be witnessed exchanging such items, so you will always be given instructions on what city you need to take the item to. Once dropped of, your reward will be waiting along with another job you can do if you want.<br><br>Be careful out there. Keep in mind that you can get a sneak attack on your enemies if you attack them while hidden. Performing such attacks will test your skills in hiding and stealth to increase the damage for the attack. Powerful foes would be best dealt with if you greet them with such a strike.";
            }
            else if (sConversation == "Tailor")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and if you do not like the appearance of your cloak or robe you could hire to me alter it for you. Some of these garments can look unusual to what I normally sell, but I can make them look normal for you. If you manage to get yourself a hood or cowl, they can sometime have their color changed. Just use it when it is on your head. You can select something you are equipped with, like a robe, and it will change its color to match. This allows you to easily set your dress with a hooded robe or cloak.";
            }
            else if (sConversation == "Scribe")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and I can decipher almost anything. There are many spellcasters that seek mystical power, but the only way to obtain such things is to explore the forgotten dungeons of the land. If you find any unusual scrolls, you can hire me to tell you what they are. It may make your spell book more complete. Also keep in mind that you can outwardly hold certain spell books in your trinket spot. This comes as a benefit if your spell book has properties that go beyond the normal bounds.<br><br>Also, if you come across any strange parchments, you can hire me and I will decipher them for you. I charge 100 gold for that service, as it is more difficult to figure out these strangely written riddles or letters. These parchments often have clues or riddles that lead to many strange and richly things...but half of the time they are simply false or misleading. I am not the only one that can figure out what parchments say. A very intelligent adventurer could also figure it out as well. Parchments may be plainly coded (20 int), expertly coded (30 int), adeptly coded (40 int), cleverly coded (50 int), deviously coded (60 int), ingeniously coded (70 int), or diabolically coded (80 int). Whether the information on it is true or false, I could not tell you...but maybe a gypsy could shed some light on it for you.<br><br>If you want some librarian duties, and you are practicing inscription, there are many books and bookshelves in the dangerous areas of the land you may want to investigate. You will need a monocle, which you could perhaps purchase or have a glass blower create for you. Some have simply come across them. These monocles will help you search the books and bookshelves in dungeons, for example. Simply use a monocle on a shelf or book pile to investigate it further. Monocles wear out, so be sure to bring enough with you if you go on a lengthy research journey. Searching these books and bookshelves may yield blank scrolls as well as scrolls of a magical nature. You can also perhaps find rare books as well.<br><br>If you are a wizard or necromancer, and wish to perform research to increase your knowledge in the ancient forms of magic, I can sell you a research pack to hold all of your research materials. Not only can you research the ancient forms of magic, but you can also research widely known spells that you may have difficulty finding the original spell. Research requires one to search the world for ancient wizard tomes of information to construct the spells. You must also become very proficient in inscription to research and scribe the new magic you learn about. If you want to pursue this research, then give me 500 gold coins and I will give you a pack for you specifically.";
            }
            else if (sConversation == "Mapmaker")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and maybe you are in search of lost treasure? If you find a treasure map that you cannot figure out, you could hire me to help you. Of course, the more treasure that is to be rumored from it will cost you that much more for me to tell you what the map says. You could also practice cartography on your own, by drawing maps yourself. If you get good enough, you can decode your own treasure maps. Treasure maps show you a portion of the world where the treasure can be found, as well as coordinates of its location, so bring a sextant with you. When you get to the spot, use a regular shovel on the map itself and you will start digging up the treasure. Be leary, however, as opening the chest may result in creatures taking notice and the will surely try to stop you from claiming your find. Lastly, I can draw you a world map to help you travel easier. If you give me 1,000 gold I will get started.";
            }
            else if (sConversation == "Mage")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and you can hire me to charge any magic wands you may have. I usually require 100 per spell circle of the wand, which will increase the charges by 5.<br><br>Also, if you are curious about the wizardly arts...I have some advice for you. The 'create food' spell not only creates food but also creates a mystical bottle of water. Make sure to eat and drink during your journey. The 'remove trap' spell should not be overlooked. It does more than simply remove traps from containers. It also will create a magical orb that goes in your backpack. This wand will passively check for traps on the floors and walls...along with those placed on containers. The 'telekinesis' spell allows you to pick up an object, that is out of your reach, and place it in your backpack. It does not work on stacked items, or items in another container. Some dungeons have hidden traps and chests within them. Although the 'reveal' spell was meant to only find creatures that hide, it will also find traps and hidden treasure containers.<br><br>Casting spells can be a tedious process, but it doesn't have to be. There is a secret that few wizards know. You can have up to 4 custom spell bars that you can cast with. These spell bars keep your favorite spells at your fingertips, and allow you to cast them quicker. To learn the commands to access these secrets, you can find them by using the 'Help' button on the paperdoll.<BR><BR>A word of warning in practicing other forms of magic, elementalism and magery cannot be bestowed upon the same spellcaster. One knowing about both forms will cause any of the spells to fail when attempting to cast. This includes having items that enhance these types of skills. An aspiring spellcaster must choose a path and move toward that goal. You can either pursue elementalism, or you can learn about the more diverse and powerful magery. If you find that you are losing interest in one of these schools of magic, and want to quickly pursue the other, then search for the Sorcerer Cave in Sosaria or the Conjurerer's Cave in Lodoria. They have crystals discovered centuries ago, that can help you forget what you learned in one area of magic so you can learn another.";
            }
            else if (sConversation == "Monk")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and I am a long time practitioner of the exotic arts of bushido, ninjitsu, shinobi, and the way of the monk. I can teach you in many of these skills and I often sell tomes and scrolls that will allow you to practice these abilities yourself. An exotic lifestyle is not for everyone, but if you choose this path you may want to explore the land in search of oriental treasures (In your Help options you can set your Play Style to Oriental). When you do this, much of the items you find will be of an exotic nature from armor, weapons, and other relics.<br><br>Both bushido and ninjitsu are the easiest to master, but those pursuing the quest of mystics or monks need to find the proper shrines and meditate at them to learn the various skills that can be used. If you acquire a Monk's Tome, it will explain all of this to you. The other rare pursuit is the way of the shinobi. These abilities enhance a ninja by provide more skills for which they can use like disguises, running as fast as a horse, or unlocking treasure chests. One only needs to be pursuing the way of the ninja and a shinobi scroll to undertake this goal.<br><br>If you simply want to buy some exotic items, I sell many for either ninjas or samurai. You are also free to use our dojo to practice or rest.";
            }
            else if (sConversation == "Necromancer")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and casting spells can be a tedious process, but it doesn't have to be. There is a secret that few necromancers know. You can have up to 2 custom spell bars that you can cast with. These spell bars keep your favorite spells at your fingertips, and allow you to cast them quicker. To learn the commands to access these secrets, you can find them by using the 'Help' button on the paperdoll.<br><br>Also, if you have the stomach for it, you can get yourself a grave digging shovel and head for the cemetery. People are buried with all sorts of valuables, and there is no need for a dead man to have them. These actions work your forensic skills, which may make you a good undertaker one day.<br><br>Before I forget, the ancient text you will find to be incorrect. The 'exorcism' spell does not actual do what the book states. It really is used against demons and the dead. If you are powerful enough, you can send them back from where they came.<BR><BR>A word of warning in practicing other forms of magic, elementalism and necromancy cannot be bestowed upon the same spellcaster. One knowing about both forms will cause any of the spells to fail when attempting to cast. This includes having items that enhance these types of skills. An aspiring spellcaster must choose a path and move toward that goal. You can either pursue elementalism, or you can learn about the deathly magic of necromancy. If you find that you are losing interest in one of these schools of magic, and want to quickly pursue the other, then search for the Sorcerer Cave in Sosaria or the Conjurerer's Cave in Lodoria. They have crystals discovered centuries ago, that can help you forget what you learned in one area of magic so you can learn another.";
            }
            else if (sConversation == "Elementalism")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and I practice magic of the elements. Unlike other forms of magic, elementalism relies on both the intellect and physical condition of the spellcaster. No reagents are required, but casting these spells require an equal use of mana and stamina. If you manage to find magical items that have a lower reagent quality, then the stamina required for spells will be reduced proportionally by that value. There are no supplement skills required for elementalists, like mages with their psychology or necromancers with their spiritualism. We do have a guild you can join at our Lyceum, which is hidden on the Devil Guard mountains, with an illusionary spell. To get there, you need only cast the Sanctuary spell. This spell cannot be used everywhere, but as you learn more about elementalism you will be able to cast it in places like dungeons to quickly get to safety.<BR><BR>If you manage to visit the Lyceum, there are four shrines to the elements of Earth, Air, Water, and Fire. Each elementalist can only focus on one element at a time, and they can change their focus whenever they want. To do so, simply step up onto the shrine of your choice. If you want to change your clothing to match your focused element, simply speak the word 'culara'. Changing focus does not affect your spell library. This means that if you have 10 spells in your Earth Elemental Spellbook, and you change your focus to Water Elemental Magic, then your changed Water Elemental Spellbook will have the same 10 types of spells in it.<BR><BR>The only way to scribe elemental spells onto scrolls is by writing the magic words with daemon blood, and casting spells can be a tedious process, but it doesn't have to be. There is a secret that few elementalists know. You can have up to 2 custom spell bars that you can cast with. These spell bars keep your favorite spells at your fingertips, and allow you to cast them quicker. To learn the commands to access these secrets, you can find them by using the 'Help' button on the paperdoll.<BR><BR>Our magic is said to have been forged by the Titans of the Elements, and many elementalists try to find their way into the Underworld to seek them out. What they desire are the spellbooks from the Titans, as they are very powerful. Most mages and elementalists have their spell casting often fail in the Underworld. Elementalists believe that equipping one of the Titan's spellbooks would allow them to explore the dark realm without this hinderance. Whether truth or falsehood, one can only try.<BR><BR>A word of warning in practicing other forms of magic, magery and necromancy cannot be bestowed upon the same elementalist. One knowing about these other forms of magic will cause any of the spells to fail when attempting to cast. This includes having items that enhance these types of skills. An aspiring spellcaster must choose a path and move toward that goal. You can either pursue elementalism, or you can learn about magery and necromancy. Elementalism knowledge even affects the forces of magic wands or runic magic. The pursuit of magic research is also something elementalists cannot achieve. If you find that you are losing interest in one of these schools of magic, and want to quickly pursue the other, then search for the Sorcerer Cave in Sosaria or the Conjurerer's Cave in Lodoria. They have crystals discovered centuries ago, that can help you forget what you learned in one area of magic so you can learn another.<BR><BR>Lastly, elemental magic is very sensitive to the forces surrounding the caster. The more armor you are wearing, the more likely your spells will fail. You either avoid wearing armor or find armor suited for spellcasters, that perhaps have a mage armor quality to them. Shields with spell channeling forces also help. Metal armor is the most obtrusive in this regard, where wooden armor is less detrimental. Leather armor is the least impactful, but finding quality clothing is the desired course.";
            }
            else if (sConversation == "LeatherWorker")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and I could fix your leather gear for you if you wish to hire me. I can fix leather armor, bear masks, deer masks, and even pugilist and throwing gloves.";
            }
            else if (sConversation == "Herbalist")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and have you ever found unusual reagents in your travels? If so, you could hire me to tell you what they are. You can't use them in potions, or magical spells, without knowing what it is you have first.";
            }
            else if (sConversation == "Furtrader")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and if you have a bear or deer skin mask you can hire me to fix any rips or tears it may have. You want to keep that in good shape don't you?";
            }
            else if (sConversation == "Bowyer")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and I specialize in repairing worn bows and crossbows. If you need my services in that regard, feel free to hire me.<br><br>I can also change a style of quiver for you if you simply hand it over.";
            }
            else if (sConversation == "Alchemist")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and maybe you found some strange liquids? If so, you could hire me to identify them for you. It takes a rare person to be able to tell what all of these liquids are, you might be surprised.";
            }
            else if (sConversation == "Blacksmith")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and maybe you are here because your armor or sword broke? You've come to the right place. I can fix almost any weapon, except for bows and crossbows. I can also fix almost any metal armor you have.";
            }
            else if (sConversation == "Armorer")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and I am very skilled in repairing metal armor. If you have any that needs my services, feel free to hire me. I'll make it almost as good as new. You don't want to be in front of a dragon with broken armor do you?";
            }
            else if (sConversation == "Knight")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + " the Knight, and perhaps you are interested in seeking the path to knighthood? It is a difficult path, but if you remain true...you will be mightier than the mightiest of barbarians.<br><br>Knight magic can be a tedious process to call forth, but it doesn't have to be. There is a secret that few knights know. You can have up to 2 custom spell bars that you can cast with. These spell bars keep your favorite spells at your fingertips, and allow you to cast them quicker. To learn the commands to access these secrets, you can find them by using the 'Help' button on the paperdoll.<br><br>Also keep in mind that we are able to remove curses. This is not only the curses on the body, but also on items. If you end up having one of your items cursed, or your tomes of knowledge locked in a cursed box, you can remove the curse on your own...if you have the skill to summon the magic of 'remove curse'";
            }
            else if (sConversation == "Provisioner")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and perhaps you need some equipment before heading out? There are many things I carry that can help you. Lanterns and torches can light your way in the darkest of dungeons. Be warned, these items will eventually burn out on you and you will have to light another. Many adventurers fall from traps set in these dark places. If you want to be more cautious, I do sell 10 foot poles. These allow you to tap containers, floors, and walls to search for traps. This works passively so you only need one on your pack and you will automatically check for such dangers. Almost all traps are invisible to the naked eye, so beware. Some are more obvious as there could be a stone face on a wall that shoots fire or mushrooms that may explode with harmful spores. With a bedroll, and a simple camp fire, you can rest safely for the night. You may also make use of small tents. These tents are useful when you find yourself in immediate danger. If you can build your tent fast enough, you can remain safe for a couple of minutes while you prepare yourself for the dangers outside. These types of tents can only be assembled outside, so don't try to use them within the dungeons and tombs.<br><br>Camping tents are what keep the best adventurers going for long periods of time. It could be weeks before one returns to a settlement, as camping tents can provide almost anything an adventurer needs. For those skilled in camping, a camping tent can provide food and water along with the unlimited safety for rest. Those experts in camping, can build their camping tents and have even more comforts. Enough to draw in other adventurers that may provide you with some of their wares like food, drink, and survival gear. These camping tents can also allow you to organize your items from your bank box. The nicest part of camping tents, is that you can use them while underground. This allows for greater dungeon exploration as you can safely store your found treasure and not overburden yourself.<br><br>We sometimes sell merchant crates for your home if you are a craftsman. These are crates where the Merchants Guild will come to your home once a day and take what is in the crate in exchange for gold. It can really help those that want to setup a shop and make a few gold from the items they craft.<br><br>If you have some unusual item, I can sometimes tell you what you can get for it, and from whom. These are strange items that are usually decorative in nature, and not something you would be able to use. It could be armor, artwork, banners, books, cloth, carpets, coins, furs, gems, gravestones, instruments, jewels, leather, orbs, paintings, reagents, rugs, scrolls, statues, tablets, vases, or weapons. If I can't tell you the value of it, then you will have to find what to do with it on your own. If I determine that it does have value, give the item to the merchant I mention and they will give you some gold for it. Just hand it to them or keep it to decorate your home.<br><br>Safe travels.";
            }
            else if (sConversation == "Architect")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and perhaps you are interested in owning land and building a home? I can only provide you with a construction contract, but it is up to you to find the area in which you wish to build. You must find a semi-flat area void of large obstructions, and clear enough for the size home you wish to build. ";

                if (Server.Misc.MyServerSettings.AllowCustomHomes())
                {
                    sText =
                        sText
                        + "You can either build a standard home, or plot you can customize yourself. ";
                }

                if (Server.Misc.MyServerSettings.AllowHouseDyes())
                {
                    sText =
                        sText
                        + "What makes the standard homes unique is that you can paint them before you build them. Simply use something to dye the contract a color of your choosing. When you build the home, it will totally be in that particular color. Of course I have seen some horrible looking homes that have been painted, but this does allow you to build structures like a dark tower or a blood red castle. You could even build a structure that looks like it was carved from ice because of this feature. Although the structure will be the color you paint it, the doors and house sign will not be. ";
                }

                sText =
                    sText
                    + "<br><br>You may find some abandoned dungeons throughout the lands. We cleared them out of small vermin and put them up for sale. If you happen to find one for sale, and you have the gold, you may purchase it.<br><br>Over the years, some wizards have fallen from either accidents or old age. They once owned great castles in the sky that we put up for sale as well. They are hard to find as you must find the mystical rope that leads to these castles in the sky. They are not as expensive as dungeons, and they also do not provide all of the space and benefits that dungeons have...but they are generally larger than castles you could build on the ground.<br><br>Decorating your home can be quite the task when you have found many interesting relics you wish to display. If you get a set of 'homeowner tools', it will make this job much easier. These tools allow you to raise or lower locked down items in your home. You can also move them north, south, east, or west. You can quickly secure or unsecure things with this tool, lock down items, or place a trash barrel. Some items can be turned in two different directions, and these tools can do that for you. If you get an item/deed that has a direction in its name (like east or south), place that item/deed on the floor of your home and use the 'flip deed' option to get the item/deed in a different direction. Keep in mind that most of these particular items are 'deeds', but there are some things like carpets or trophies that look like the item that will be placed in the home. If you do place a deeded-type item in your home, you can remove it (re-deed it) by chopping the item with an axe. You can get rid of the trash barrel in a similar fashion.";

                if (Server.Items.BasementDoor.IsEnabled())
                {
                    sText =
                        sText
                        + "<br><br>If you want to have access to the public basement from your home, you simply need to purchase a basement trapdoor and secure it on the floor in your home. This public area is accessed by many places in the land, either from people's homes or from certain shops like tinkers, blacksmiths, or tailors. Basements have areas where people can craft, but only if they enter the basement area from a merchant's shop. It provides a common area for people to meet and crafters to sell their wares and perhaps fix your items. Basements are safe areas where you can relax and meet with others.";
                }
                if (Server.Items.MovingBox.IsEnabled())
                {
                    sText =
                        sText
                        + "<br><br>If you ever need to move from your current home to another, the work can be quite involved. I do sell some housing crates you could use. They hold many, many items and the crate is easy to carry even when entirely full. The crates, however, can only be opened by the one I sell it to and they can only be opened when inside someone's home. If you try to lock them down or secure them in the home, the item count will go toward you home's storage. It is also best to fill the crate while it is on the floor in your house and not in your pack. Otherwise you may be trying to put containers, with more items than your pack can hold, within the crate while in your pack and that won't work well. Once the crate is done being filled, however, you can then place it in your pack with no issues. You can also open the crate when at the bank, if you need to move your possessions to a newly placed home. Be careful, however, because the crate can be stolen by others or simply lost. Then your worldly possessions will be forever gone.";
                }
                if (Server.Misc.MyServerSettings.LawnsAllowed())
                {
                    sText =
                        sText
                        + "<br><br>For home owners that want to add some character to the outer perimeter of their homes, they can purchase some lawn tools from me. These tools allow you to place items like trees, rocks, water, yard decorations, and various types of ground terrain outside the boundaries of their home. After you purchase them, simply take them home with you and use them while standing on your land. You will be given choices on what you want to build. Each choice costs a particular amount of gold, where any such funds will be drawn from your bank box. You can learn additional details about these tools when you use them in your home.";
                }
                if (Server.Misc.MyServerSettings.ShantysAllowed())
                {
                    sText =
                        sText
                        + "<br><br>If you are a homeowner that wants to remodel their home, then you can purchase some remodeling tools from me. These tools allow you to place items like walls, doors, stairs, or other decorative things within it. After you purchase them, simply take them home with you and use them while standing in your house. You will be given choices on what you want to build. Each choice costs a particular amount of gold, where any such funds will be drawn from your bank box. You can learn additional details about these tools when you use them in your home.";
                }
            }
            else if (sConversation == "Guard")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and I am a guard on patrol here. There aren't many laws of the land, but the few there are...are something to be followed. Don't try to steal from anyone. If caught, you will be cast as a criminal for 2 minutes. During this time, you can be killed by others without repercussions to them. They may also freely take things that belong to you. Most importantly, we will kill you on sight. Other things that will make you a criminal is to attack another innocent person.<br><br>Murder is the most foul of crimes. The town crier will know of all those in the land wanted for murder. Killing another innocent person will cast you as a murderer. Each murder violation will only be forgotten by all if you are within the realm for 40 real-world hours. Whether you are a murderer or a criminal, the townsfolk will have not dealings with such filth. It is best to stay on the right side of law and order.<br><br>We also have set bounties on criminals that plague our lands. If you bring me the head of a pirate, or one of the many types of thieves, you will be given gold for your efforts. There are also assassins, hunters, or ninjas about. We have a price on that murderous bunch as well. It is normally an offensive act to cut the head from a corpse, but doing such a thing on this scum will bring no ill will toward you.";
            }
            else if (sConversation == "Healer")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ". There are probably a few things you need to know about our group. We will heal you for free, but only every so often. We will see that you are in need of aid and help. Death, is another matter. To summon spirits from the dead is an exhausting task, as any good wizard will attest. If your spirit does find its way here, we will require a donation to our order to help you. It is a small contribution to return to the land of the living to be sure. The gods will resurrect you on their own, but the toll on your body will be great if you allow them to do that.<br><br>There are also shrines around the lands. These places not only allow one to tithe their gold, but it also will resurrect the soul. These shrines will require the same amount of gold or tithing that we would, but the shrines may be closer to your corpse than we are.<br><br>We have heard rumors of resurrection potions, and even a mixture one could make with witchery brewing, that could bring the soul back to life. We don't see such things so it is hard to be sure. Maybe you will have better luck in such matters.<br><br>If you are leery of the use of magic for healing, bandages can be the best item you can carry with you. Some have gotten so good at healing with bandages, that they are known to cure one of poison or bring them back from the dead. To use bandages easier, you have a couple of options. You can use the built-in macros for bandaging yourself or others. Another option is the '[bandself' or '[bandother' commands. Either works fine and could possibly save your life.<br><br>No matter how one reaches their end, their spirit will be guided to the nearest healer or shrine if they seek aid in the resurrection of their souls.<br><br>Once one is brought back from the dead, they often search for the place where they met their demise. This can be a simple matter when one reaches their end in a hallway or cave, but the wilderness is a different matter as the landscape can look the same from place to place. If you need any help finding your remains, simply use the '[corpse' command and you will be led to it...if you are close enough to it.";
            }
            else if (sConversation == "Druid")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + " the Druid. I am the protector of all things in the forest. All plants and animals serve a purpose in the world and the balance of that must be maintained. If your animal companion were to suffer a horrible fate, you may be able to bring their soul to me and I would resurrect them for you. I do not charge for such services, as it is merely my duty to maintain this balance.<br><br>You may also be interested in druidic herbalism to make unique potions. There is a book called 'Druidic Herbalism', that will explain how you can explore this hidden magic of nature.";
            }
            else if (sConversation == "Cook")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + " the culinary around here. To become a chef, simply cook! For many of the preparations you need to be near a heat source, this is most often an oven, but in some instances, such as barbeque, a camp fire or forge is sufficient. Below is a few examples of cooking heat sources:<br><br>Campfire<br>Fireplace<br>Forge<br>Heating stand<br>Oven<br><br>Some common cooking tools needed are a rolling pin, skillet, or a flour sifter.";
            }
            else if (sConversation == "Sage")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + " the Sage. If you have an unknown magical wand, or maybe some strange artifact you cannot identify...then maybe I could help you with that. I only require about 500 gold to identify wands, and 5,000 gold to identify artefacts. Of course, you could practice this skill yourself and you may no longer need my services.<br><br>If you want some librarian duties, and you are practicing inscription, there are many books and bookshelves in the dangerous areas of the land you may want to investigate. You will need a monocle, which you could perhaps purchase or have a glass blower create for you. Some have simply come across them. These monocles will help you search the books and bookshelves in dungeons, for example. Simply use a monocle on a shelf or book pile to investigate it further. Monocles wear out, so be sure to bring enough with you if you go on a lengthy research journey. Searching these books and bookshelves may yield blank scrolls as well as scrolls of a magical nature. You can also perhaps find rare books as well.<br><br>Also, a bit of advice before you leave. Knowledge is everywhere, and it should be sought. You may find books in dungeons that contain legends and clues. You may talk to someone in a city or village that may provide valuable information. Don't leave a stone unturned. If you find a book, see if its pages contain anything of value. I myself sell many tomes that may help you through the trials of this world.<br><br>Also, if you come across any strange parchments, you can hire me and I will decipher them for you. I charge 100 gold for that service, as it is more difficult to figure out these strangely written riddles or letters. These parchments often have clues or riddles that lead to many strange and richly things...but half of the time they are simply false or misleading. I am not the only one that can figure out what parchments say. A very intelligent adventurer could also figure it out as well. Parchments may be plainly coded (20 int), expertly coded (30 int), adeptly coded (40 int), cleverly coded (50 int), deviously coded (60 int), ingeniously coded (70 int), or diabolically coded (80 int). Whether the information on it is true or false, I could not tell you...but maybe a gypsy could shed some light on it for you.<br><br>If you are a wizard or necromancer, and wish to perform research to increase your knowledge in the ancient forms of magic, I can sell you a research pack to hold all of your research materials. Not only can you research the ancient forms of magic, but you can also research widely known spells that you may have difficulty finding the original spell. Research requires one to search the world for ancient wizard tomes of information to construct the spells. You must also become very proficient in inscription to research and scribe the new magic you learn about. If you want to pursue this research, then give me 500 gold coins and I will give you a pack for you specifically.<br><br>If you want a grand quest to unearth an artifact, you can seek my advice in your journey. My advice is not cheap, where you may be spending 10,000 gold for the best advice I can give. To begin your quest, hand me enough gold for my advice. I will give you an artifact encyclopedia from which you can search for the first clues on the whereabouts of your artifact. These encyclopedias come in varying degrees of accuracy, depending on how much gold you are willing to part with.<br><br>Legend Lore<br><br>  Level 1 - 5,000 Gold<br>  Level 2 - 6,000 Gold<br>  Level 3 - 7,000 Gold<br>  Level 4 - 8,000 Gold<br>  Level 5 - 9,000 Gold<br>  Level 6 - 10,000 Gold<br><br>We are never able to give you absolute accurate information on the location of an artifact, but the higher the encyclopedia's lore level, the better the chances you may find it. Once you receive your encyclopedia, open it up and choose an artifact from its many pages. If you are not sure what artifact you seek, simply look through my wares for sale. At the end of my inventory, you will see research replicas of these artefacts priced at zero gold. You can hover over these artefacts to see what they may offer you, but you cannot buy them. Artefacts such as books, quivers, and instruments will be shown with some common and random qualities, where finding the actual artifact will have somewhat different properties. The remaining items have set qualities as well as a number of Enchantement Points that you can spend to make the artifact more customized for yourself. When you find these artefacts, single click them and select the Status option to spend the points on the additional attributes you want. After selecting an artifact from the book, you will tear out the appropriate page and toss out the remainder of the book. This page will give you your first clue on where to search. Areas the artifact may be in could span many different lands or worlds, where some you may have never been or heard of. You will be provided with the coordinates of the place you seek, so make sure you have a sextant with you.<br><br>Throughout history, many people kept these artefacts stored on blocks of crafted stone. These crafted stones are often decorated with a symbol on the surface, where a metal chest rests and the item may be inside. Some treasure hunters find the chests empty, realizing the legends were false. The better the lore level of the book you ripped the page from, the better the chance you will find the artifact. If nothing else, you may find a large sum of gold to cover some of your expenses on this journey. Some may provide a new clue on where the artifact is, and you will update your notes when these clues are found. The most disappointing search may yield a fake artifact. These turn out to be useless items that simply look like the artifact you were searching for. <br><br>These quests are quite involved and you may only participate in one such quest at a time. If you have not finished a quest, and try to seek a sage for another, you will find that the page of your prior quest will have gone missing. It would have been surely lost somewhere. If you finish a quest, either with success or failure, I will not have any new advice for you for quite some time so you will have to wait until then to begin a new quest. So good luck treasure hunter, and may the gods aid you in your journey.";
            }
            else if (sConversation == "Bard")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + " and I am quite the musician. Bards not only entertain others in the local tavern, we also have mystical abilities with our music. We can cause others to become aggressive with each other, or we can play soothing music to calm them down. We can also play music so irritating, that our opponents will often fumble in battle. One of the rarest forms of bardic performances are usually in a bard's song book. Although I might have an empty book for sale, the songs are something of a lost art. A few bards have found the notes and lyrics deep within dungeons, but those stories may be simply rumors. I do sometimes have a song or two for sale, but that is about it. I believe there were sixteen songs written over centuries, at least those with magical effects.<br><br>Bardic songs can be used just like wizards cast spells. You can call forth the magic from your book, or use the song bars as explained by using the 'Help' button on the paperdoll. Unlike other types of magic, bardic songs do have a command you can type for each song. This command is something similar to '[KnightsMinne', and you can see which command goes with which song in your bardic song book. Many of these songs effectiveness is dependent on the bard's knowledge of music. The best results of these songs are performed by those that are good at musicianship, provocation, discordance, and peacemaking. You also need an instrument to play these songs. The bardic song book will have your set your instrument of choice. If you lose the instrument, simply open the book and assign a new instrument. If you have an instrument with slayer properties, these will have greater effects on those enemies. Each time you play one of these songs, your instrument's uses will decrease by one, so be wary of your instrument's condition.<br><br>If you raise bees, you could probably make some wax you can use on instruments. It helps them last longer. Sometimes I sell this type of wax as well.<br><br>Some instruments have mystical powers. If you are a skilled enough musician, you can equip these instruments or song books where you would normally place trinkets. This can allow you to take advantage of the magical effects the items may have. If you decide to make in instrument with your carpentry skill, keep in mind the the better the wood and skill, the more uses you will get from the instrument.";
            }
            else if (sConversation == "Tanner")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and I could fix your leather gear for you if you wish to hire me. I can fix leather armor, bear masks, deer masks, and even pugilist and throwing gloves. I sometimes sell taxidermy kits as well. If you are good at tailoring, you buy one of these kits with will allow you to mount certain creatures as trophies. Once you get the taxidermy kit, look over the various trophies you can make. You then need to carry the taxidermy kit with you when you go hunt these creatures. If you do not have the taxidermy kit with you, you will not get the item necessary to make the trophy. Good luck hunting.";
            }
            else if (sConversation == "Tavern")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and you have come to the right place if you don't want to travel alone. Henchman are followers that can join you on adventures so you do not have to traverse the dangerous dungeons alone. You can purchase the services of a henchman from barkeeps, tavern keepers, or inn keepers. There are three different types of henchman you can have...a fighter, archer, or wizard. These henchman use a similar system for tamed animals, with a few exceptions. First, you can heal your henchmen with your healing skill. Second, you cannot transfer an active henchman to another player. Third, you cannot stable your henchmen. Lastly, you cannot be bonded to your henchmen. Each 'henchman item' represents the type of henchman you have (helms for fighters, crossbows for archers, or crystal balls for wizards). Although you cannot transfer your henchman, you can give the 'henchman item' to another person where they will then have possession of the henchman. Along those lines, if someone else manages to get your 'henchman item' from you, the henchman is then theirs.<br><br>You must be in an area such as an inn, tavern, or home to call your henchman. Once you call them, they will take possession of the 'henchman item' and keep it until one of the following occur...they are killed, you release them, or they get annoyed with the lack of treasure being found. For every 5 gold you give them, they will travel with you for 1 minute. This equals to 300 gold per hour, where the maximum they will take from you is enough for 6 hours of adventuring. You can pay your henchman in a few different ways. You can give them many types of treasure like coins, gems, or rare items for payment. Rare items are those unique items you may find that you can give to merchants in towns for a high price. Each time you pay them, you will get a message indicating how many minutes they will be traveling with you. When they have about 5 minutes left, they will begin to express their annoyance for the lack of treasure. This is a warning to find some treasure quickly, or your henchman will leave. If your henchman does depart, the 'henchman item' will appear in your backpack. The next time you call upon your henchman, make sure you have something to give them so they will travel with you. A henchman always remembers how much treasure you have given them. This means if a henchman has about 4 hours left of travel, and you 'release' them, they will remember that they have 4 hours of travel when you call upon them again. Keep in mind that this 'adventuring time' does not count down when you are in an area like a tavern, home, inn, bank, or camping tent.<br><br>Each henchman will have a unique name, title, and clothing. If you do not care for your henchman's appearance, simply give the 'henchman item' to an innkeeper, tavern keeper, or barkeeper and they will exchange the henchman for another one. When you do this, the new henchman will retain any bandages and time remaining for adventuring the previous henchman had...as payments and bandages are transferred to the new henchman. As mentioned earlier, you do not stable henchmen. You instead 'release' them and their 'henchman item' will appear in your backpack and you can call the henchman later. You can release henchman anywhere you are. If a henchman is slain, the 'henchman item' will appear in your backpack. The name of the 'henchman item' will indicate that the henchman is dead. You will have to seek out a healer and 'hire' them to resurrect your henchman. When you 'hire' a healer to do this, it will cost an amount of gold indicated on the item...and you must select the 'henchman item' when the targeting cursor comes up. The 'dead' indicator will vanish and you can then return to an area like an inn, tavern, bank, or home and call your henchman again.<br><br>If you ever mount a creature or magically enhance your travel speed, your henchman will mount a steed shortly after so they can keep up with you. Henchman are only as able of an adventurer as you are. Their skill level is an average value of your total skills. Their stats are a distribution of your total non-magically-enhanced stats. So basically, the better you are...the better your henchmen will be. These henchmen only help you in your battles. They do not pick locks or remove traps. That is up to you to manage. You can give them bandages and they will use them as they need them to cure their poison or heal their wounds. If you ever want to know how many bandages they have left in their pack, simply say 'report' and they will tell you. You can give them potions though and they will drink them...giving you an empty bottle back. The potions they can make use of are heal, cure, rejuvenate, refresh, and mana potions. You are only able to take two henchman with you at any one time.";
            }
            else if (sConversation == "Gypsy")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + ", and we have a reputation of having visions from the past or future. If you have a deciphered parchment, and you are wondering if the words written speak the truth, I could 'reveal' you whether it is truth or lie. I would ask for payment in gold depending on the way the parchment was written. There are plainly coded (100 gold), expertly coded (200 gold), adeptly coded (300 gold), cleverly coded (400 gold), deviously coded (500 gold), ingeniously coded (600 gold), or diabolically coded (700 gold) parchments I could read over for you.<br><br>If you perhaps found a simple note, and are wondering if the words on it are true, I will happily look into the tarot and see if the scroll was written truthfully or falsely (100 gold).<br><br>If you have a legend you need verified, that requires great concentration and effort. If you want me to seek the validity of a legend, they cost according to the likelihood of their story. So you may have a highly unlikely (4000 gold), unlikely (3500 gold), somewhat unlikely (3000 gold), somewhat reliable (2500 gold), reliable (2000 gold), or highly reliable (1500 gold) legend could look over for you.";
            }
            else if (sConversation == "MadGodPriest")
            {
                sText =
                    "So, "
                    + sYourName
                    + "...you have learned the true name of the Mad God. His disciples grow every day. Soon we will be a powerful voice to call upon him and he will free us from this prison Mangar has woven. Those that truly worship Tarjan, do so deep within the Catacombs. Take this key, and seek enlightenment in the darkness below.";
            }
            else if (sConversation == "NecroGreeter")
            {
                sText =
                    "Hail, "
                    + sYourName
                    + "...this is the island of Dracula the Master Vampire. He has made this place a sanctuary for his kind, but does have patience for those the study the necrotic arts. Any necromancers that have achieved an apprentice level of skill, an undertaker that has achieved an adept level of skill, vile death knights that are equally skilled, or those strange Syth cultists are able to roam the island without fear of attack from Dracula's minions. They are also able to build sanctuaries for themselves here as well. Be warned, no one is to trespass into Dracula's castle.<br><br>For those necromancers, undertakers, death knights, or Syth cultists that wish to build a stronghold here, there are many places in which to do so. The village of Ravendark is nearby, but most lock their doors to only those that may live on this island as they trust no others that understand nothing of what they do.<br><br>The slaying of the Master's minions is by no means a concern to him, and many necromancers, undertakers, death knights, or Syth cultists often do so to help in their goals for power.<br><br>For other travelers, be warned. The island is a dangerous place to traverse.";
            }
            else if (sConversation == "Kylearan")
            {
                sText =
                    "Mangar has trapped me in my own tower, by unleashing his minions in my hallways. We were once friends, Mangar and I. Now power has corrupted him to the point where companions serve no purpose.<br><br>Take this ebony key. It will not work on the door to Mangar's tower, but he did say that it would work on his secret door beneath the streets of Skara Brae. I also want you to have this small chest that has a relic inside. Choose one so it may help you on your quest. Go now, and may you vanquish Mangar and his evil void.";
            }
            else if (sConversation == "Assassin")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". You managed to find our small but secret guild of assassins. If you feel you have the spirit to join our ranks, I am the one you would speak to. Although I lead the guild's organization, Xardok is the high ruler of our guild. He lives on a small island in Sosaria, and you can seek him out if you want to perform any duties for the guild. I do, however, sell some wares that may help an assassin in their pursuit of dispatching others. If you find yourself in trouble with the law for murder, you could wait 8 hours of real world game time to see if the guards forget about the crime, but any murder committed beyond that will require 40 hours of real world game time to ensure the guards forget about a single murder.";
                if (Server.Misc.MyServerSettings.AllowBribes() >= 1000)
                {
                    sText =
                        sText
                        + " You could also hire me for "
                        + Server.Misc.MyServerSettings.AllowBribes()
                        + " gold to bribe the guards to forget about a single murder you may have committed. Guild members pay only half of that amount and I cannot convince the guards to forget fugitives. If you do not have enough gold in your pack, I can simply take it from your bank box.";
                }
            }
            else if (sConversation == "Xardok")
            {
                sText =
                    "Welcome to my island, "
                    + sYourName
                    + ". Some call this place a haven for the villainous, but I consider it merely a place to relax without the worries of the law. From the noblest of knights, to the murderous of scoundrels...my castle welcomes anyone within its halls. There is even a thief in my southern tower, and they have a metal chest that can access one's bank box. Come here to practice, sell goods, or buy supplies...you can even rest here for the night.<br><br>Now you may have heard rumors that this is the home of the Assassins Guild. That may, or may not be...true. The Assassins Guild are a group of people who do things that others wish to not dirty their hands with. People go to them to have someone in particular...put to death. Anyone may officially join the guild, they need only to seek an assassin guildmaster. Some believe they settle among the thieves in their guild, secretly looking for new members. Only the unsavory of guild members are welcome into the fold when assassin work is sought, so one with good karma is usually kept at bay from such tasks. Members are given targets in which they must seek and slay. Each task must be completed to get another. If you fail at one task, the guild leader is one to not grant another unless atonement is given. The more famous an assassin, the better chance to get a high priced victim. Of course the more gold for a target, usually means how difficult the target may be to handle. Those that complete tasks for the guild, often lose karma since society thinks what they do is despicable...but that is nothing a good assassin worries about.<br><br>To get a target assigned to you, one must simply ask the guild leader if they wish to 'hire' them. They would not send you to a land you have never been, but they may send you to any town or dungeon in lands you have traveled. If you do not know the location of a particular place, that is of no concern to the guild. You had better begin your exploration of such areas. Any other details of the victim can be read in the quest log (typing '[quests'). When such a task is completed, one would usually tell the guild leader that they are 'done'.<br><br>If one were tasked to kill a village citizen, the guild has been known to pay the right people to help others forget about the assassin's murder. Of course, such jobs are difficult as the assassin must escape the village to collect their reward and be absolved of the crime they were 'wrongly' accused of. When performing these tasks, it is of utmost importance that only the intended victim be assassinated. Anyone witnessing the deed should be quickly fled from as the guild cannot make a village forget about too many murders. The easiest way to dispatch of a troublesome individual is to catch them alone, without the eyes of the guards on you. If such a thing is not possible, some say that the most effective method is to poison some food or drink. Greater poison works the best for these situations. Once you have some tainted food or drink, give it to your victim to ingest. Although many can tell the food and drink is tainted, the ones that are normally marked seem to foolish at times. Make sure you can hide right away, before those nearby know what has occurred. Make sure you can then sneak out of the area before you are caught. Don't wait for your mark to suffer the poison's effects. Just get out of there. If you used greater or deadly poison, they will more than likely perish in due time. If you are unable to move with great stealth, or lack the magic to escape, then being an assassin may not be for you.<br><br>But...in the end...all of this is just legend and hearsay.";
            }
            else if (sConversation == "XardokFail")
            {
                sText =
                    "What are you waiting for? You have been given your task, now carry it out with diligence! We did not choose a victim for you that is too difficult...we made sure of that. If you feel this victim is beyond your mettle, I will remind you that the guild cares little of what you think. If you wish to rid yourself of this contract, then you must pay the bounty offered as your atonement for failure. So whatever the reward were to be, you must put that total in the box of atonement...if you wish to slither away from what we ask of you that is.";
            }
            else if (sConversation == "ScrapMetal")
            {
                sText =
                    "This barrel is for rusty scrap metal. If you come across any rusty metal items, put them in this barrel and you will get 5 gold per stone's weight of rusty metal. The metal workers remove the impurities and smelt it back into bars of iron. Any members of the Blacksmiths Guild will get 10 gold per stone's weight of rusty metal.";
            }
            else if (sConversation == "Aquarium")
            {
                sText =
                    "You can see many different types of fish in this tub. Usually, expert fishermen will catch a truly unusual fish and put them in these tubs...as the proprietor of this place will pay well for them. They are hard to catch, but the better the fisherman...the more likely they will catch a fish that will fetch a good price. Any members of the Mariners Guild will get twice the amount of gold for the fish they catch.";
            }
            else if (sConversation == "TrailMap")
            {
                sText =
                    "This is a trail map that shows a secret path to get to the location drawn on the map. You can only use these maps if you have at least an 80 in either skills of tracking or cartography. They can never be copied and they eventually wear out from use. If you double click the map while it is in your pack, you will follow the path of the map by yourself. No one will be able to follow you on your quick journey to this place. If you set the map down and double click it, then others will be able to use the map to go with you on your journey as they can double click the map left behind to follow you. The original map will be put back into your pack, while this map left behind will only remain for about 30 seconds so your comrades should make haste and follow. If a map goes to a world you have not discovered the way into on your own, then you will toss the map out as you cannot seem to find the path to this place.";
            }
            else if (sConversation == "CampTent")
            {
                sText =
                    "This is a camping tent that you can use to get away from the dangers of the land and rest. You can only use these tents if you have at least a 40 in the camping skill and they eventually wear out from use. If you double click the tent while it is in your pack, you will setup the tent for yourself. No one will be able to follow you in the tent unless they have a tent and the appropriate skill. If you set the tent down and double click it, then others will be able to use the tent to rest as they can double click the tent to follow you in. The original rolled tent will be put back into your pack, while the standing tent is left behind and will only remain for about 30 seconds so your comrades should make haste and follow you in. If anyone wants to leave the tent, then simply double click the tent flap you came in by. Anyone can stay in the tent as long as they want, but they will return to the spot where they used the tent when they leave.";
            }
            else if (sConversation == "DeathKnight")
            {
                sText =
                    "If you are on a path of chaos, set forth by the Bloody Handed, then you must strike fear in the minds of men who dare attempt to extinguish the fire of darkness. If you have reached the reputation of despicable, and have achieved the status of journeyman death knight, then step into the pentagram and speak the name of the Bloody Handed and you will transform into the nightmares that men flee from and children perish from the mere thought.<br><br>If you have reached the status of grandmaster death knight, and your deeds were despicable enough, I can summon a dread horse for you. All I require is 10,000 gold from you as tribute.<br><br>Lastly, if you want to be granted the gift of demonic wings, then I can turn any cloak you may have into such things. They do not allow you to fly, however. The gold I require is 35,000, but your karma will affect this price where it may cost 20,000 for the most vile or 50,000 for those pure of heart. If you find you do not like the wings, give them back to me and I will turn them back into a cloak without the requirement of gold to do so.";
            }
            else if (sConversation == "MerchantCrate")
            {
                sText =
                    "Merchant crates are something that craftsmen can secure in their homes and sell the goods they make. Once a day, someone from the Merchants Guild will pick up anything left in the crate. They will leave gold in the crate for the owner's hard work. When you put something in the crate, you will be aware of the gold value of the item placed in it. A craftsmen may only acquire gold from armor, weapons, or clothing that were crafted. Any non-crafted armor, weapons, or clothing will be valued at 0 gold. Crafted armor and weapons will have varying values depending on the resources used to create the item. Also durability and quality may increase the value. Almost anything crafted will have a value to the Merchants Guild. Other items like potions, scrolls, tools, furniture, or food can be sold for a price. Any tools must have at least 50 uses to be of any value. So if an item cannot be crafted, then you probably will not get any gold for it. The exception to this are ingots and logs, as they are highly sought in the land. Different types of ingots are worth more depending on the type.<br><br>The crate will indicate how much gold it has available to transfer to yourself in the form of a bank check. Single click the crate and select the 'Transfer' option to withdraw all of the gold from the crate. Although there is a gold value indicated on the crate, the one withdrawing the amount may get more depending on whether they are in the Merchants Guild and/or they have a good Mercantile skill. These crates must be secured in a home to be of any use.";
            }
            else if (sConversation == "Patch")
            {
                sText =
                    "As some things are added to the world, your client may need to be updated to accommodate the changes. This bulletin board will display the last date a patch was prepared, to better help you decide if you installed it already or not. If you downloaded the client on or after the displayed date, you will not need the patch shown. If you need to download it, single click the bulletin board and select 'Open'. Your web browser will open so you can get the patch. When it is downloaded, unzip the content into your UO directory, overwriting the files within it. Make sure your client is closed before doing this.";
            }
            else if (sConversation == "GodOfLegends")
            {
                sText =
                    "You stand within the Hall of Legends, "
                    + sYourName
                    + ". This is where the most notable champions are laid to rest. Some were the most lawful of heroes, and others may have been the greatest villains of the land. They all share one common trait. They were brave in the face of danger and have slain many powerful creatures that roam the lands. They had killed great dragons, mighty demons, and powerful undead. Their names are known throughout the land and their history forever remembered.<br><br>Legends were born from their bravery, and items were forged and wielded by them. From Elric's sword of Stormbringer, to Merlin's mighty staff, these legendary artefacts were sometimes lost, stolen, hidden, or found by others. Although these items were once among the mundane, these champions used these items in many battles. Those victories made these items into legendary artefacts.<br><br>It is not your time to lay among the mighty, but you could begin your journey with an item of power forged in your name. I have placed a book on the pedestal. If you have 15,000 points of fame, 15,000 points of karma either toward good or evil, and 10,000 gold for tribute, then you may select an item from the book. Although I will create the item for you, it will appear as something simply sold by merchants. As long as you are equipped with the item, it will grow in power as you achieve victory over the many fearsome foes of the lands.<br><br>Upon selecting an item, your fame and karma will reduce accordingly. It is up to you to rebuild them. You can seek as many legendary artefacts as you are able to achieve. They are very special compared to regular items of common appearance. Legendary artefacts will never need to be repaired. If you meet an untimely end, you will have it in your possession when you return to the living. Certain traps that affect equipped items will have no adverse effects on legendary artefacts. Creatures, that attempt to ruin legendary artefacts, will fail in the attempt. If you are careless with your artifact, and leave it lying about, then fate will speak for what may happen to it. Your item will gain levels as you equip it and gain victory over your adversaries. When the item gains a level, single click on your item and select 'Status' to give the item more power. Be careful adding power to items, as you cannot change any attributes once you select them. You can use regular dye tubs on legendary items, making them any color you choose. If you want to rename your artifact, show me you have been gifted with one by handing it to me. I will return your artifact, along with a branding iron you may use to mark your artifact with any name you choose.";
            }
            else if (sConversation == "Farmer")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". Welcome to my market. I have grown everything here and you might find some food that could help you on a long journey. Many farms grow things like corn, wheat, and turnips. We just simply take them from the garden when they have fully grown. There are also fruits as well. These are found throughout the land as you can use a bladed item on a apple, peach, or pear tree to pluck the fruit from them. If you find yourself on a rare tropical island, you can also perhaps get bananas, dates, or coconuts in the same fashion. Farming may take more work but it is safer than trying to punch a bear for the desired meat.";
            }
            else if (sConversation == "Courier")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". I sometimes deliver mail from prominent folks looking for a hardy adventurer to take on a particular task. We travel from village to city, city to village, looking for the ones we need to deliver to. These messages are usually sent to a specific person to find a rare item from a place others fear to go. If you end up receiving a message yourself, make sure you can do what is asked of you. If you cannot, you will probably not see another message delivered to you anytime soon.<br><br>You will be provided with the coordinates of the place you seek, so make sure you have a sextant with you and the mailed message. Without the mailed message, you will likely never find the item.<br><br>The items sought will be stored on blocks of crafted stone. These crafted stones are often decorated with a symbol on the surface, where a metal chest rests and the item may be inside. These quests are handled in a 'virtual' manner. What this means is that any achievements are real, but any references to items found are not. If your quest mailed message states that you found the item, you will not have the item in your backpack...but you will 'virtually' it. The mailed message will keep track of this fact for you. Because of this, you will never lose that item and it remains unique to your mailed message. The mailed message knows you found it and have it. Give the mailed message to the one who sent it to you for your reward.";
            }
            else if (sConversation == "Painter")
            {
                sText =
                    "Hail, "
                    + sYourName
                    + ". As you can see about you, I am a painter that has done many portraits over the years. I could do one for you but I am out of canvases at the moment. If you happen to find one, give it to me and I will paint a portrait of you as you are now. Of course I would require 5,000 gold for my time, but you will be happy with it for that I am sure. Sometimes the tailors make canvases, but they rarely sell them. I do paintings in quite a few different styles. If I create one of you that you would like to look different, simply give me the painting back and I will replace it free of charge. Even if you have a new title, I can add it to a painting that was previously painted if you hand it over to me. I do want my customers happy after all. Of course, you wouldn't need my services if you were good at working with wax, but I digress.<br><br>If you manage to find any rare paintings during your travel, I will pay double that the art collector would. They always like to hoard the rare art so I have to give a bit extra if I am to ever collect these rare pieces.";
            }
            else if (sConversation == "Trophy")
            {
                sText =
                    "This is a wooden base board for you to mount a fish or head on. These mounts can then be used to decorate your home. Simply single click this board and select 'Use'. You can then target a corpse of a creature or fish. If it can be mounted, you will then create the trophy to take with you. Any creatures you mount will be engraved with who slain the create, and where the creature was slain. You cannot mount the head of every creature. Below is a listing of creatures you can mount the heads of:<br><br>Balrons<br>Bears<br>Bugbears<br>Cerberus<br>Chimeras<br>Cyclops<br>Daemons<br>Deer<br>Demons<br>Devils<br>Dragon Turtles<br>Dragons<br>Drakes<br>Ettins<br>Fiends<br>Flesh Golems<br>Gargoyles<br>Giants<br>Goblins<br>Gorillas<br>Griffons<br>Hell Beasts<br>Hippogriffs<br>Hydras<br>Lions<br>Lizardmen<br>Manticores<br>Meglasaurs<br>Minotaurs<br>Nighmares<br>Ogres<br>Orcs<br>Owlbears<br>Pixies<br>Ratmen<br>Stegosaurus<br>Styguanas<br>Teradactyls<br>Tigers<br>Titans<br>Trollbears<br>Trolls<br>Tyranasaurs<br>Unicorns<br>Walrus<br>Watchers<br>Wyverns<br>Yetis<br>";
            }
            else if (sConversation == "Stonecrafter")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". My name is "
                    + sMyName
                    + " and I am a crafter of stone. I sell tomes that can teach you how to mine for stone, but you must have obtained a grandmaster title in mining in order to do so. I also sell books that will show you how to manipulate the stone into various statues and other forms. To be able to do this, however, you would need to be a grandmaster in carpentry. There are different colors of stone you may find, and they mimic the types of ore you might dig up. Anything you create from stone will have the color of the stone you crafted it from. You can use what you create, sell it to others you may meet, or simply put it into a merchant crate for the merchant guilds to trade. You can change the color of most crafted items with a furniture dye tub, or other means you can discover to alter the color. You can usually flip the items to face one direction or another with the use of homeowner tools. If you have a larger block of stone, that places a statue or piece of furniture in your home, you can use a similar method to flip them. In this case, set the block on the floor in your home and use the option to flip a deed. The direction will change in the name and then you can build the statue or furniture in your home. Most items, that are not blocks you build in your home, can have their names changed. Double click the item and you will be asked for a new name. This is a useful option as you can then name statues or tombstones you carve.";
            }
            else if (sConversation == "Stake")
            {
                sText =
                    "You have found a wooden mallet and stake. If you manage to slay a vampire, you can single click on this and use it to drive a stake into the heart of the creature. Doing this will give you credit for such kills. When you have acquired a value of at least 1,000, take this to the priest in Britain or the City of Lodoria and they will give you the gold you seek. If you are looking to become a priest yourself, then you will need some skill in healing and spiritualism along with at least 2,500 karma. Once you have earned 1,000 gold with this mallet and stake, give it to the priest and they will lead you down a path of divinity.";
            }
            else if (sConversation == "Devon")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". I am "
                    + sMyName
                    + " and I have been fishing these waters for many years. There isn't much competition in these waters, as there are only a few of us that have dared to venture the Underworld. I have seen some odd creatures though, and have heard even stranger stories from others. I have built a few ships for adventurers, even though it is mostly petrified wood this deep under the surface. I may have one that interests you. Unlike the surface seas, launching a ship here is much easier and thus we never really need to rely on a dock master for aid. This huge cavern seems to summon a large enough breeze to push the sails, so you shouldn't have troubles navigating he waters. Be leery of the lake, as legends tell of the Titan of Water is said to lurk within the murky depths.<br><br>If you get lost within this cavern, you can use a magic sextant to find your way. It may seem silly as there is no sun here, but I do have magic sextants that can see through the cavern ceiling when gazed through. Keep that in mind if you are searching for something as well.";
            }
            else if (sConversation == "Pets")
            {
                sText =
                    "Greetings, "
                    + sYourName
                    + ". I am "
                    + sMyName
                    + " and I have been working with animals for many years. taming is quite the feat than only a few can accomplish. If you have pets, we can stable them for you if you wish. If you have a grandmaster skill in camping, you can acquire a hitching post and use it in your home to stable your own pets.<br><br>You can only have a particular number of animal companions with you, based on your skills with animals. Having a good skill in herding can help you manage more pets.<br><br>If you are looking for a pack animal, I may be able to help. Many adventurers seem to acquire much treasure in their journey, and they often complain on how much they had to leave behind because they simply couldn't carry it. A pack horse can help, as they are inexpensive. Many of these animals have been slain in dangerous areas, so be careful and protect them from such things. We sometimes are able to raise a healthy pack mule, however, and they are much more rugged than other pack animals. They require more control to bring with you, but they carry much and monsters seem to leave them be for some reason. Because they are often sought by adventurers, they cost much more gold, but it may be well worth it. I have also heard stories of tamers actually training elephants and dinosaurs to carry their goods, but I have yet to see it.";

                if (Server.Misc.MyServerSettings.NoMountsInCertainRegions())
                {
                    sText =
                        sText
                        + "<br><br>Be aware when exploring the land, that there are some areas you cannot ride mounts into. These are areas such as dungeons, caves, and some indoor areas. If you are riding atop an ethereal, it will move to your backpack when you enter such areas. You can use the ethereal mount when you leave that area. If you are riding an animal, then the animal will run off to a safe place when you enter such areas. They will reappear when you leave the area and you can continue riding on. If you cannot find your riding animal, for any reason, check the stables as it may have wandered there. If you have an animal that you cannot ride in these areas, but want it to accompany you anyway, then leave the area and dismount the animal before continuing on. If you are without your mount for too long, they will eventually go back to the stables where the stablemaster will draw gold from your bank every week. If you have no gold, they will release your mount into the wild.";
                }
            }
            else if (sConversation == "Powerscroll")
            {
                sText =
                    "Hail, "
                    + sYourName
                    + ". I am "
                    + sMyName
                    + " and I am one of the teachers of higher knowledge here in Lodoria. Since we elves can live for hundreds of years, we have learned much more about certain skills than that of you humans. Although we teach many elves here, within these castle walls, you would need to take on a journey to the shrines of enlightenment if you wish to pursue such things. If you are able to part with the gold necessary for our acquired knowledge, then you must take the scroll to the lost land of Ambrosia. Seek the appropriate shrine of enlightenment and read the scroll there.<br><br>Wondrous: Up to 105 Skill<br>Exalted: Up to 110 Skill<br>Mythical: Up to 115 Skill<br>Legendary: Up to 120 Skill<br>Power: Up to 125 Skill<br><br>Ambrosia once could only be reached by ship, but since the defeat of Exodus, a portal was said to have torn open on his island that is supposed to lead there. Of course these are only rumors, but you may want to start there. Good luck "
                    + sYourName
                    + ".";
            }
            else if (sConversation == "Frankenstein")
            {
                sText =
                    "Hail, "
                    + sYourName
                    + ". I am "
                    + sMyName
                    + " and I am the undertaker here in the guild. Although my fellow necromancers study the aspects of death, I stay down here to study the revival of life. I have spent most of my life trying to learn the secrets of Victor Frankenstein, but I have yet to obtain any of his journals that may lead me further in my studies. I did have an acquaintance that was helping me, and he did manage to find some text on the subject, but alas his ship was lost at sea and he was never seen again. It is just as well because it sounded like his discovery only touched the surface of reanimated corpses.<br><br>If you manage to find any of Victor Frakenstein's journals, I would be most pleased in acquiring them from you. Of course you are free to attempt and follow his instructions. Perhaps you may have more success than I if your forensic skill is good enough. It is said that these reanimated corpses can be either very powerful combatants or very strong slaves. I have heard that the power of such creatures is dependent on the power of the brain you can find to put in it. So a brain from an ogre wouldn't be as good as a brain from a storm giant. To get the body parts you need, you will need to take one of Frankenstein's journals with you as you use a blade on corpses of giants. The better your forensic skill, the better chance you will get particular body parts to construct a creature. You will find arms, torsos, legs, heads, and brains from many different creatures. These generally will not do as you need to find 'severed' limbs, heads, and torsos. You also need a 'fresh' brain as the others are usually rotten and have lost all spark of life. Once you gather them, you will need a power coil like the one I have here in my lab. Doing the instructions in the journal will help animate the corpse. You are free to use my power coil, but I also get them from a local tinker so you can buy one from me to place in your home if you wish.";
            }
            else if (sConversation == "Jester")
            {
                sText = Server.Items.BagOfTricks.JesterSpeech();
            }
            else if (sConversation == "Enhance")
            {
                sText =
                    "This is a special tool that is only available to members of the particular crafting guild, and it can only be used by such members. Simply use this on an item to enhance its capabilities. Only master craftsmen can use these items and it will cost a particular amount of gold to add enhancements. If you use this on an item that you crafted, and it bears your mark, the cost to add enhancement will cost much less. You can only use this item if you are near your guildmaster, or near a shoppe you have in your home. This is a shoppe related to the particular skill you are using here. There are also rumors that you can use these items in the Enchanted Pass, where elves are known to craft extraordinary items. An item can only be enhanced to a certain level of power, but it should give you a way to craft truly mystical items.";
            }
            else if (sConversation == "EnhanceJewels")
            {
                sText =
                    "This is a special tool that is only available to members of the particular crafting guild, and it can only be used by such members. Simply use this on an item to enhance its capabilities. Only master craftsmen can use these items and it will cost a particular amount of gold to add enhancements. You can only use this item if you are near your guildmaster, or near a shoppe you have in your home. This is a shoppe related to the particular skill you are using here. There are also rumors that you can use these items in the Enchanted Pass, where elves are known to craft extraordinary items. An item can only be enhanced to a certain level of power, but it should give you a way to craft truly mystical items.";
            }
            else if (sConversation == "Jedi")
            {
                sText =
                    "Greetings, child. I have not spoken to anyone in quite the long time. If you are wondering, I am a descendant of what is known as the Jedi. Long ago, our order was marooned on this world. Although there was no means to leave, we had a quest to rid this world of the Syth that arrived during that same time. As the Syth grew in numbers, so did the Jedi. As we slowly dealt with the Syth threat, many of our order joined society and became what this world knows as priests. They healed the sick and provide teachings of virtuous behavior to all who would listen. If you are of good character (positive karma) and have an aptitude for psychic ability (psychology of 25 or more) you are welcome to pursue the path of the Jedi. All I ask is for a show of commitment. I know of a family that is in desperate need, and I would like to leave them 5,000 gold to start life anew. If you are ready for enlightenment, and are willing to part with the gold, then please hand it over to me and I will give you the wisdom to start your journey in the path of the Jedi.";
            }
            return sText;
        }
    }
}

/* TO ADD CONVERSATIONS TO NPCS, INCLUDE THE LINES OF CODE BELOW...

using Server.Misc;
using Server.ContextMenus;
using Server.Gumps;

        ///////////////////////////////////////////////////////////////////////////
        public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list )
        {
            base.GetContextMenuEntries( from, list );
            list.Add( new SpeechGumpEntry( from, this ) );
        }

        public class SpeechGumpEntry : ContextMenuEntry
        {
            private Mobile m_Mobile;
            private Mobile m_Giver;
            
            public SpeechGumpEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
            {
                m_Mobile = from;
                m_Giver = giver;
            }

            public override void OnClick()
            {
              if( !( m_Mobile is PlayerMobile ) )
                return;
                
                PlayerMobile mobile = (PlayerMobile) m_Mobile;
                {
                    if ( ! mobile.HasGump( typeof( SpeechGump ) ) )
                    {
                        mobile.SendGump(new SpeechGump( mobile, "Camping Safely", SpeechFunctions.SpeechText( m_Giver, m_Mobile, "Ranger" ) ));
                    }
                }
      }
    }
        ///////////////////////////////////////////////////////////////////////////

*/
