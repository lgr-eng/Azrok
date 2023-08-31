using System;
using Server;
using Server.Items;
using System.Text;
using Server.Mobiles;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using System.Collections;
using System.Globalization;

namespace Server.Items
{
    public class LoreBook : DynamicBook
    {
        [Constructable]
        public LoreBook()
        {
            Weight = 1.0;

            if (BookTrue > 0) { }
            else
            {
                writeBook(Utility.RandomMinMax(0, 46));
            }
        }

        public void writeBook(int val)
        {
            BookRegion = null;
            BookMap = null;
            BookWorld = null;
            BookItem = null;
            BookTrue = 1;
            BookPower = 0;

            ItemID = RandomThings.GetRandomBookItemID();
            Hue = Utility.RandomColor(0);
            SetBookCover(0, this);
            BookTitle = Server.Misc.RandomThings.GetBookTitle();
            Name = BookTitle;
            BookAuthor = Server.Misc.RandomThings.GetRandomAuthor();

            switch (val)
            {
                case 0:
                    BookTitle = "Akalabeth's Tale";
                    BookAuthor = "Shamino the Anarch";
                    SetBookCover(1, this);
                    break;
                case 1:
                    BookTitle = "The Lost Land";
                    BookAuthor = "Sentri the Seeker";
                    SetBookCover(42, this);
                    break;
                case 2:
                    BookTitle = "The Balance Vol I of II";
                    BookAuthor = "Dedric the Knight";
                    SetBookCover(80, this);
                    break;
                case 3:
                    BookTitle = "The Balance Vol II of II";
                    BookAuthor = "Dedric the Knight";
                    SetBookCover(80, this);
                    break;
                case 4:
                    BookTitle = "The Black Gate Demon";
                    BookAuthor = "Zalifar the Wizard";
                    SetBookCover(66, this);
                    break;
                case 5:
                    BookTitle = "The Blue Ore";
                    BookAuthor = "Jarg the Blacksmith";
                    SetBookCover(69, this);
                    break;
                case 6:
                    BookTitle = "Crystal Flasks";
                    BookAuthor = "Frug the Explorer";
                    SetBookCover(32, this);
                    break;
                case 7:
                    BookTitle = "The Curse of the Island";
                    BookAuthor = "Sempkin Burg";
                    SetBookCover(23, this);
                    break;
                case 8:
                    BookTitle = "The Dark Age";
                    BookAuthor = "Nedina the Ghastly";
                    SetBookCover(25, this);
                    break;
                case 9:
                    BookTitle = "The Dark Core";
                    BookAuthor = "Erethian the Mage";
                    SetBookCover(67, this);
                    break;
                case 10:
                    BookTitle = "Death to Pirates";
                    BookAuthor = "Granafla the Sailor";
                    SetBookCover(65, this);
                    break;
                case 11:
                    BookTitle = "The Death Knights";
                    BookAuthor = "Arul Martos";
                    SetBookCover(78, this);
                    break;
                case 12:
                    BookTitle = "The Darkness Within";
                    BookAuthor = "Cyrus Belmont";
                    SetBookCover(79, this);
                    break;
                case 13:
                    BookTitle = "The Destruction of Exodus";
                    BookAuthor = "Hafar of the Red Robe";
                    SetBookCover(67, this);
                    break;
                case 14:
                    BookTitle = "The Knight Who Fell";
                    BookAuthor = "Darun the Priest";
                    SetBookCover(78, this);
                    break;
                case 15:
                    BookTitle = "The Fall of Mondain";
                    BookAuthor = "Gram the Seventh";
                    SetBookCover(55, this);
                    break;
                case 16:
                    BookTitle = "Forging the Fire";
                    BookAuthor = "Malek the Smith";
                    SetBookCover(62, this);
                    break;
                case 17:
                    BookTitle = "Forgotten Dungeons";
                    BookAuthor = "Curan the Fighter";
                    SetBookCover(2, this);
                    break;
                case 18:
                    BookTitle = "The Cruel Game";
                    BookAuthor = "Killun the Poor";
                    SetBookCover(50, this);
                    break;
                case 19:
                    BookTitle = "The Ice Queen";
                    BookAuthor = "Suri the Bard";
                    SetBookCover(34, this);
                    break;
                case 20:
                    BookTitle = "Luck of the Rogue";
                    BookAuthor = "The Gray Mouser";
                    SetBookCover(13, this);
                    break;
                case 21:
                    BookTitle = "A Tattered Journal";
                    BookAuthor = "Unknown";
                    SetBookCover(0, this);
                    break;
                case 22:
                    BookTitle = "The Curse of Mangar";
                    BookAuthor = "Lemka the Cloaked";
                    SetBookCover(59, this);
                    break;
                case 23:
                    BookTitle = "The Times of Minax";
                    BookAuthor = "Halgram the Obscure";
                    SetBookCover(56, this);
                    break;
                case 24:
                    BookTitle = "Rangers of Lodoria";
                    BookAuthor = "Grimm the Tracker";
                    SetBookCover(77, this);
                    break;
                case 25:
                    BookTitle = "Gem of Immortality";
                    BookAuthor = "Batlin the Druid";
                    SetBookCover(58, this);
                    break;
                case 26:
                    BookTitle = "The Gods of Men";
                    BookAuthor = "Perdue the Magician";
                    SetBookCover(75, this);
                    break;
                case 27:
                    BookTitle = "Castles Above";
                    BookAuthor = "Harkan the Explorer";
                    SetBookCover(71, this);
                    break;
                case 28:
                    BookTitle = "Staff of Five Parts";
                    BookAuthor = "Zuri the Wizard";
                    SetBookCover(24, this);
                    break;
                case 29:
                    BookTitle = "The Story of Exodus";
                    BookAuthor = "Dreova of the Isles";
                    SetBookCover(67, this);
                    break;
                case 30:
                    BookTitle = "The Story of Minax";
                    BookAuthor = "Jaxina the Wise";
                    SetBookCover(56, this);
                    break;
                case 31:
                    BookTitle = "The Story of Mondain";
                    BookAuthor = "Milydor the Sage";
                    SetBookCover(55, this);
                    break;
                case 32:
                    BookTitle = "The Bard's Tale";
                    BookAuthor = "Ramzef the Bard";
                    SetBookCover(37, this);
                    break;
                case 33:
                    BookTitle = "Death Dealing";
                    BookAuthor = "Murgox the Warlock";
                    SetBookCover(27, this);
                    break;
                case 34:
                    BookTitle = "The Orb of the Abyss";
                    BookAuthor = "Gribs the High Mage";
                    SetBookCover(24, this);
                    break;
                case 35:
                    BookTitle = "The Underworld Gate";
                    BookAuthor = "Garamon the Wizard";
                    SetBookCover(2, this);
                    break;
                case 36:
                    BookTitle = "The Elemental Titans";
                    BookAuthor = "Xavier the Theurgist";
                    SetBookCover(46, this);
                    break;
                case 37:
                    BookTitle = "The Dragon's Egg";
                    BookAuthor = "Druv the Dwarf";
                    SetBookCover(9, this);
                    break;
                case 38:
                    BookTitle = "Magic in the Moon";
                    BookAuthor = "Selene the Wizard";
                    SetBookCover(71, this);
                    break;
                case 39:
                    BookTitle = "The Maze of Wonder";
                    BookAuthor = "Risa the Scholar";
                    SetBookCover(49, this);
                    break;
                case 40:
                    BookTitle = "The Pass of the Gods";
                    BookAuthor = "Mareskon the Elf";
                    SetBookCover(64, this);
                    break;
                case 41:
                    BookTitle = "Valley of Corruption";
                    BookAuthor = "Willum the Druid";
                    SetBookCover(45, this);
                    break;
                case 42:
                    BookTitle = "The Demon Shard";
                    BookAuthor = "Vanesa the Sorcereress";
                    SetBookCover(67, this);
                    break;
                case 43:
                    BookTitle = "The Syth Order";
                    BookAuthor = "Xandru the Jedi";
                    SetBookCover(78, this);
                    break;
                case 44:
                    BookTitle = "The Rule of One";
                    BookAuthor = "Asajj Ventress the Syth Lord";
                    SetBookCover(78, this);
                    ItemID = 0x4CDF;
                    Light = LightType.Circle225;
                    break;
                case 45:
                    BookTitle = "Antiquities";
                    BookAuthor = "Daran the Collector";
                    SetBookCover(7, this);
                    break;
                case 46:
                    BookTitle = "The Jedi Order";
                    BookAuthor = "Zoda the Jedi Master";
                    SetBookCover(16, this);
                    ItemID = 0x543C;
                    Light = LightType.Circle225;
                    break;
            }

            GetText(this);
            Name = BookTitle;
        }

        public LoreBook(Serial serial)
            : base(serial) { }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.WriteEncodedInt((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadEncodedInt();

            if (BookTitle == "Staff of Five")
            {
                BookTitle = "Staff of Five Parts";
                Name = "Staff of Five Parts";
            }

            GetText(this);
        }

        public static void GetText(LoreBook book)
        {
            if (book.BookTitle == "Akalabeth's Tale")
            {
                book.BookText =
                    "Mondain, second born of Wolfgang, a great king of old, wished to gain his brother's inheritance, and so he used his great powers for evil. Many years had Mondain traversed the lands of Akalabeth spreading evil and death as he passed. He created deep dungeons, so deep and extensive that their lower depths had never been explored. In these dungeons he unleashed more evil. He sent thieves, skeletons and snakes to dwell near the surface, and daemons and balrons to guard the depths. Now blood flowed freely in Akalabeth, and foul creatures soon came to roam near the surface. Mondain cast such sickness and pestilence upon Akalabeth, that both man and beast lived in constant fear. Thus was the Dark Age of Akalabeth.";
            }
            else if (book.BookTitle == "The Lost Land")
            {
                book.BookText =
                    "Although I, myself, failed in my search for the Lost Continent, I bring the story often told by the minstrels who roam the land, in hope that it will aid in thy quest...Many, many years ago, there lived a strong and sensitive people who inhabited the continent of Ambrosia. These people developed great powers over the forces of nature, and 'tis rumored that even the power to change one's physical being rested within the realms of their knowledge. From these stories grew the legends of the magic shrines of Ambrosia. The land prospered as the years passed, and the strange power grew in strength. Then, without warning, there was a great and violent upheaval, and the earth sank suddenly into the sea. A great whirlpool pulled the land beneath the depths of the waters. The whirlpool no longer exists, yet many claim to have found a moongate to the lost land of Ambrosia.";
            }
            else if (book.BookTitle == "The Balance Vol I of II")
            {
                book.BookText =
                    "I learned of the Ophidians from the sage in Britain. They live among the Serpent Island and have a unique religion of the three serpents that provide balance to the universe. Although folklore by many, I believe that this religion stems in truth. They are known as the Serpents of Balance, Order, and Chaos. When Exodus pulled the Serpent of Balance from the Serpent Island, to guard his castle, balance began to waver. The Stranger freed the Serpent, allowing it to return but the effects are still felt. Chaos and Order still battle amongst each other in the void, and Order seems to be winning. The power of Chaos was accidentally released and possessed three poor souls. They now roam the dungeon of Bane as the Chaos Banes, and they each possess one of the blackrock serpents needed to maintain balance. I have tried to slay one of them, but failed in my attempts. A gypsy in Lodor told me that I would need three unique items if I am ever to defeat all of the Chaos Banes. I will need to find the Orb of Logic if I am to defeat the Bane of Insanity. One has to acquire the Scales of Ethicality if they ever hope to defeat the Bane of Anarchy. Lastly, we need to find the Lantern of Discipline to slay the Bane of Wantoness. These items could be anywhere in the realms, but the gypsy said to search the dungeons for them. It will be quite the journey, but the balance must be maintained if we are to survive. I was also warned that these items are from the void, so if I manage to find one I could lose it if another draws it from elsewhere. I need to find these items and dispatch the Banes as quickly as I can.";
            }
            else if (book.BookTitle == "The Balance Vol II of II")
            {
                book.BookText =
                    "The blackrock serpents are almost within my grasp. Each one represents the Serpents of Balance, Order, and Chaos. If I am ever to subdue the Serpents of Chaos and Order, I will need to have all three of these items to succeed. I found an ancient scroll within the library of Lord British, that gave me the much needed information I needed. Although categorized as being a legend by the librarian, I believe this to actually be true. I need to find the Wall of Lights in the Serpent Sanctum. If I approach it, I will appear in the room of both this world and the void. I must approach the statues of Order and Chaos and announce that I am here to restore the balance. That should give one of the blackrock serpents the power of the Serpent of Balance. Then if I touch each of the statues, the serpent will appear in this realm where I can then subdue it. I must do this with both serpents as they must both be subdued. Once their blackrock forms have their subdued souls captured, I can seek out the Great Earth Serpent and announce to him that I have maintained the balance. I am off to face the Bane of Insanity, as I have found the Orb of Logic. I will attempt to find the other two if I survive the coming battle.";
            }
            else if (book.BookTitle == "The Black Gate Demon")
            {
                book.BookText =
                    "For centuries, the greatest spell casters have attempted to reach the Ethereal Plane. Success has yet to be achieved, but my latest research has uncovered a scroll deep within the halls of Dungeon Doom. Although written in a strange, drow language... I was able to decipher most of what it contained. Although many wizards summon the aid of demons from other worlds, one particular mind flayer was able to summon a black gate demon. This particular demon is believed to be from the Ethereal Plane. I think striking a deal with this demon is something that is not so easily done, but if perhaps he can be defeated in battle, a gateway can be opened to the place I seek to go. I have summoned 12 demons so far, and none of them were a black gate demon. If I could only find the hidden city of the mind flayers, maybe there I could learn the secrets to calling forth this spirit.";
            }
            else if (book.BookTitle == "The Blue Ore")
            {
                book.BookText =
                    "Caddellite is a blue metal with very interesting properties. It can filter out harmful energy, cause physical attacks to harm the attacker, is easier to wear than other plate metal armors, and thus provides a bit of swiftness for the wearer. It is not a native metal to the world we know, and can only be found in meteors that have fallen from the sky. I have found one deposit of this rare metal, and it is rumored to have destroyed the inhabitants of Ambrosia. Even with my skills as a master miner, I have failed to dig away the ore that glows bright. I have heard tales in the taverns about the legendary blacksmith known as Zorn, who left these lands centuries ago and has been in the service of the Black Knight for many moons. He is known to carry a adamantium pickaxe that is strong enough to chip away at the glowing blue stone. Some even say he was once a smith for the gods. I have hired some mercenaries to sneak into the Black Knight's vault, where Zorn is believed to be. If I could get his pickaxe from him, I could dig up some of this ore and then travel to the elven dragon forge. I will just need to follow my map to the valley in which they live, in the Savaged Empire. If I could make a suit of this armor for Lord British, he may ask me to become a member of his court.";
            }
            else if (book.BookTitle == "Crystal Flasks")
            {
                book.BookText =
                    "I think the creature was made of pure liquid. It came at me while I was searching for an artifact in Dungeon Shame. When I struck the beast, a thick gooey substance flew forth and covered the ground. It was painful to walk on for sure. I vanquished the creature and decided to bring some of this spilled liquid to the alchemist in Lodoria, but the bottles I had could not contain the fluid. When I later told my story to the alchemist, she told me that I would need to somehow find a crystalline flask in order to scoop up the substance and bring it to her. She warned me to be careful if I manage to get a flask full of this strange liquid. If I spill it, it would cover the ground and be as harmful as if it spew forth from the monster from which I got it from. According to her knowledge, no one knows how to make crystalline flasks and they are very rare to find. Since they were more common centuries ago, I feel my best chance of finding one is searching the dungeons of the land as they contain items from a time long forgotten.";
            }
            else if (book.BookTitle == "The Curse of the Island")
            {
                book.BookText =
                    "It started with Batlin, a druid of considerable magical powers. He was born in Yew, and grew up with the Druids. As a young adult, he started to travel throughout the land, meeting Elizabeth and Abraham during that time. He went to Skara Brae during that time, and asked Mangar for the answers to life and death. When Batlin learned there were none, his darkness began. Contacted by the Guardian a short time later, he, Elizabeth, and Abraham created the Fellowship in their hunger for power, to enable the Guardian to take over the land of Sosaria. Failing that vile quest, Batlin overheard the Archmage Zekylis talking about a place called the Serpent Island. By orders from the Guardian, Batlin made his way to the Serpent Island. He was to capture the essences of beings known as the Banes of Chaos, which the Guardian would unleash on Sosaria. Being hungry for power, Batlin was going to use the Banes to seize power himself, but something happened and they were freed from their magical prison. Possessing three of Batlin's followers, the Banes killed Batlin and fled to their own areas of the Serpent Island. This had far reaching consequences, as some of the creatures were becoming cursed by the Banes' influence. Some adventurers have spoken of these cursed monsters, and how mightier they became once cursed. Many have perished by these beasts, but those that defeated them sometimes returned with treasure beyond belief. Sages have no idea how long the curse will last, and what creatures will be corrupted, but brave adventurers sometimes hunt them down to destroy them. Fare well if you run into these cursed beasts.";
            }
            else if (book.BookTitle == "The Dark Age")
            {
                book.BookText =
                    "'Tis said that long ago peace and tranquillity covered the lands, food and drink flowed freely, man and beast lived in peace, gold and silver abounded. It was the golden age of Sosaria. Mondain, second born of Wolfgang, a great king of old, wished to gain his brother's inheritance, and so he used his great powers for evil. Many years had Mondain traversed the lands of Sosaria spreading evil and death as he passed. He created deep dungeons, so deep and extensive that their lower depths had never been explored. In these dungeons he unleashed more evil. He sent thieves, skeletons and snakes to dwell near the surface, and daemons and balrogs to guard the depths. Now blood flowed freely in Sosaria, and foul creatures soon came to roam near the surface. Mondain cast such sickness and pestilence upon Sosaria, that both man and beast lived in constant fear. Thus was the dark age of Sosaria. There arose from the land a man, pure and just, to battle the Dark Lord. British, Champion of the White Light, did battle with Mondain deep within the labyrinth of dungeons, eventually driving him from Sosaria forever. British of the White Light was proclaimed Lord British, Protector of Sosaria. Alas, much damage had been suffered unto the lands. The Revival of Sosaria had begun.";
            }
            else if (book.BookTitle == "The Dark Core")
            {
                book.BookText =
                    "Some say it came from the future. A machine that seems more demon than metal. Exodus was a sourge upon the land of Sosaria, created by the hands of Mondain and Minax. When the stranger destroyed the mechanical being of Exodus, the demonic automaton that lied beneath was unleashed. It now uses its programming for travelling from land to land, never staying in one place too long. It goes to the tombs and dungeons, recording everything it sees from the monsters that lurk within. It learns to be a more effective opponent, with a recent demonstrating with the instant slaying of my grizzly bear companion. It possesses a force field that can alternate between magic and melee protection. It also emits beams of energy that electrify the soul. Why would one attempt to face such a being? It is the dark core I seek. Within the chest of this metal demon, Exodus has a core that stores the multitude of information it learns. The information within the core is not what I seek, but destroying the core to unleash its power is. I have found the ancient gargoyle city of stone in the Savaged Empire, but I have yet to find the Forge of Virtue within, where I must plunge the core. If what the gargoyles speak of is true, an item placed on the Shrine of Diligence will absorb the power of the core when it is destroyed. I must also speak the magical mantra of 'Vas An Ort Ailem', and throw the core into the forge. The shrine is said to be next to the forge, but finding it means nothing if I cannot track down where Exodus will be next. The lands are so vast that finding him will prove to be quite difficult. Time is of the essence. Even if I manage to get the dark core, I have very limited time before Exodus rebuilds itself and the core will leave my grasp and return to its chest. I wonder if anything can destroy this infernal machine.";
            }
            else if (book.BookTitle == "Death to Pirates")
            {
                book.BookText =
                    "Some believe that when a ship is to be swallowed by the sea, the souls of those on board are claimed by her as well. I served on the Blue Wave for many years. We would take cargo from Lodoria City to far off ports such as Glacial Hills or Springvale. One cold day, we were to bring the an unusual crate to an island to the far south western part of Lodor. We were unaware of a settlement there, but the gold was good and we set sail. This island had the look and feel of pure evil. An old man on board told us tales of pirates that came to this island for a safe haven, but were cursed to live among the dead that roam woods. The mountains were dark, the soil was mud, and the trees were blackened as if burned. A pale figure approached us on the dock and took possession of the crate. His hands were white as clean bone and his voice was eerie sounding. He tossed us a sack of the remaining gold and we went on our way. We made sail as fast as we could back home. We barely left the sight of that place when a ship came at us from the east. The wood was a ghostly white and we could make out some shuffling around the deck. As the ship approached, the horror became more real. This was a barge of the dead. They boarded our vessel and killed almost every man on board. They didn't take any plunder, but instead sunk the Blue Wave into the sea. Only, Vrendora, Selena, and I survived. We floated at sea for days until Captain Feldora rescued us in her ship, the Velvet Sky. Upon our return to the Port of Dusk, Vrendora soon went mad and was killed by the local guards. Selena got her own ship and crew and I hear she searches the sea for that ship. I decided to spend my remaining years Springvale, sharing stories for ale. Tales of the sea and how there are more to fear out there than krakens.";
            }
            else if (book.BookTitle == "The Death Knights")
            {
                book.BookText =
                    "He was the first of the Death Knights, brought into service by the Devil Lord known as Brazuul. That was the day the Kas the Kind was forever known as Kas the Bloody Handed. He spread terror throughout Sosaria and Lodoria, along the way luring 14 others into his mad quest to rid the world of the order of law. A group of Paladins chased them from one end of the world to the other, defeating each as found. Kas laid each disciple to rest at the bottom of various dungeons, in the hope that their tomb would be left undisturbed. There are many that believe these tales to be ones used to scare children from leaving the safety of their villages, but I have found clues leading to the Tomb of Kas in Sosaria on an ancient map I found on Dracula's island in Lodoria. It is believed that the Death Knights often built their fortresses there, along with the necromancers of the land. This map leads to the mountains, but I am curious of the back of the map. Written in blood are the words 'Mortem Mangone'. I am not sure what they mean, but soon I may get Kas' book and lantern and begin to learn the ways of the Death Knight. If my research is correct, a Death Knight may only have one book and lantern. Obtaining any other would cause the prior to vanish. I think this was the way that Kas kept his loyal subjects limited to the 14 he chosen himself. Will I be worthy? Have my recent deeds been vile enough to draw his attention? Perhaps I should learn a bit about knightship from a warrior guildmaster in Umbra or Ravendark, or Kas may not answer my call.";
            }
            else if (book.BookTitle == "The Darkness Within")
            {
                book.BookText =
                    "His name was Dracula, and he was once a Baron in the land of Sosaria. Although a good man, rage and hatred had sent him into the arms of darkness. Dracula was once the ruler of the city of Montor. They enjoyed years of peace as Dracula had built walls around the city, protecting it from any dangers lurking outside. One night, an assassin scaled the walls and murdered Dracula's wife in her sleep while Dracula was visiting Britain. Upon Dracula's return, he locked himself in his bedroom for weeks. One night, witnesses had seen him sneak out of the city. One of the guards was alerted and followed the Baron, only to lose him when he entered Dungeon Doom. It was months later, when Dracula was spotted in the village of Grey. It was late at night and he was biting the neck of the local seamstress, apparently drinking her blood. The guards arrived too late to apprehend him for his crimes. These sightings continued from each settlement as the nights came and went. Some believed he was searching for the assassin that murdered his wife. Others believed that he was cursed by the vampires and only sought blood from the living. Lord British led a group of his best guards to hunt down Dracula and end his thirst for blood. They pursued him into the night, traveling south of Britain. Dracula sought sanctuary in the Tower of the Lich and was never seen again.";
            }
            else if (book.BookTitle == "The Destruction of Exodus")
            {
                book.BookText =
                    "After the end of Mondain and Minax, the people of Sosaria thought that the worst was over... but the worst was yet to come. Exodus, their offspring and creation... neither completely demon nor machine... wanted vengeance for the destruction of its creators. Beginning a campaign of terror, he raised an island from the sea and then threatened to rip Sosaria apart with his powers and armies of evil. The Stranger returned for a third time to save the world from this new evil. This time however, the hero had three companions to survive against the Exodus' hordes. Together, they traveled through the land, recovered information, before finding the Four Cards in the lost lands of Ambrosia. With the help of the Time Lord, the group was able to learn what to do in order to defeat Exodus. After recovering the Exotic Weapons and Exotic Armour, they were ready to confront him. On the Isle of Fire, they first bypassed the Great Earth Serpent and then fought their way through the minions of Exodus, until finally arriving at the core... the part of Exodus that was a computer. Inserting the cards, the machine exploded and Exodus was no more. Now the castle of Exodus lies in ruins. Those who dared to explore it, claimed that demons and undead roam the halls beneath the ruined fortress. Some still dare to enter as riches are believed to lie within.";
            }
            else if (book.BookTitle == "The Knight Who Fell")
            {
                book.BookText =
                    "Knighthood is a noble quest one takes to bring light to a land of darkness. Unknown evils run amok and these knights are the defenders of peace that we enjoy in this world. A knight's power is often granted due to their generosity. When they destroy evil, they often find riches that are too much to keep for themselves. They would take some of this wealth and leave it at shrines, altars, or statues of goddesses. Then the priests would collect this gold and distribute it among the poor and less fortunate. One knight did not believe in this mantra. He wanted all the wealth he could collect, often killing others for theirs. His soul was so corrupted, that his powers of knightship were slowly darkened and twisted into something putrid and evil. He donned black armor and terrorized villages and cities to take what they had. Knights were sent to dispatch this traitor of the faith, but many died. Lord British assembled an army led by his greatest knight to find this black knight. They chased him all of the way to the mysterious island of Umber Veil. The village of Renika was burning when the army arrived. Many of the survivors were barricaded in the nearby church, while others locked themselves in the mountain castle. They told the army that the black knight fled to the Serpent Island. The army gave up the chase, since the black knight would no longer terrorize their lands. They helped Renika stand on their own again, and then returned home. That was many, many years ago. No one has seen th black knight in Sosaria since. There has been rumors in the taverns over the years. Some claimed to have sailed the Serpent Island and found an island where the black knight had built his stronghold. Some even claimed that he has the largest underground vault they have ever seen. Everything the black knight has ever taken is supposedly down there, alone with those tasked to guard it. I think these stories are exaggerated, as those that tell these stories have nothing to show of the vault. We should just be glad he is gone, forever.";
            }
            else if (book.BookTitle == "The Fall of Mondain")
            {
                book.BookText =
                    "Sosaria was in need of a stalwart hero, one who would brave perils horrific to consider. A plague had befallen the realm, a scourge was upon the land! The villages layed wasted, ruinous mounds of ashes where once trod peasants stout of heart and sound of mind, where once lay fields of grain and fruit, where kine and fowl grew fat upon the bounties of Sosaria. All manner of wicked and vile creatures preyed upon the people and ravaged the land. 'Tis the doing of one so evil that the very ground trembled at the mention of his name. Mondain the wizard hath wrought his malice well. The nobles bickered amongst themselves, and each hath retired to the confines of his keep in hopes of watching the downfall of his rivals. Verily, the Evil One hath heaped indignity upon curse by releasing upon the realm a host of creatures and beasts so bloodthirsty and wicked that the defenseless people fell as grain before the reaper's scythe. These denizens of the underworld held sway over all that can be surveyed, save for the strongholds of the nobles besotted with their own ambition. Nowhere in the once peaceful country could a traveler find safe passage or lodging, save in the keeps of the self-proclaimed kings...and they demanded hard labors for their indulgences. Only the young Lord British remained steadfast in the vision of a peaceful and united Sosaria. In his castle and his town the pure of heart found an ally and replenishment for the needs of one who hath chosen to fight for the realm. He aided in ridding the land of the scourge that hath befallen it. Without his aid, Sosaria would have surely perished before the onslaught of the maleficent necromancer.";
            }
            else if (book.BookTitle == "Forging the Fire")
            {
                book.BookText =
                    "The bending of steel is something done for centuries, but before the rise of man...one forged with the power of volcanic fire. Purslos was said to be a gargoyle and an excellent craftsman, who could not only cause steel to shape to his will...but also enhance it with the power of the island's magma. Legend tells of Purslos making a sword for his master, Tuxluka. The sword was said to be of solid fire and burned as well as it cut. Tuxluka used this dagger to win the Ophidian war and brought peace to the Serpent Island. One day we may learn the secrets to this method of blacksmithing. Whether it be fable or fact, the stories are too abundant to ignore.";
            }
            else if (book.BookTitle == "Forgotten Dungeons")
            {
                book.BookText =
                    "I have spent my life searching for gold, gems, and jewels. Although I have found much, blood was always spilled along the way. Comrades fell, enemies vanquished, I now live the life of kings. I didn't need to build great castles or kingdoms in the land. I didn't need to rule a vast expanse to flaunt my wealth. I simply took what I earned, and I live here now in its now lit hallways. Many of dungeons I have been. Some big, some small. The small ones were quick to search to be sure. One day, when an old wizard accompanied me, we searched a small dungeon for anything of value. It had none, but the creatures within were many and they were slain without effort. Tired from the day's travel, we decided to make camp for the night within the darkened rooms of this place. That is when the wizard mentioned that this would make a good home, if one had the gold to hire hands to clean it and fortify the walls. The wizard had no clue on what gold I had in the many banks of the land, but I thought his idea was well thought. We returned to Devil Guard the next day and we parted ways. I traveled to Moon and hired many men to make this place my home. I have cleared many dungeons in my day, but this is my favorite.";
            }
            else if (book.BookTitle == "The Cruel Game")
            {
                book.BookText =
                    "The matters of gods can be dull to those who share the thrones of such power, so dull that a few of them decided to wager on the fall of worlds. The gods of flame, sickness, power, and ice made a deal that would determine which world would fall from the gifts granted to them. They decided to each build a mystical forge in different lands, and simply sat by and watched the events unfold. The god of flame built his forge in the Serpent Island. The forge was so hot...it tore a hole in the land. The god of sickness built her forge in the most beautiful forest in the Savaged Empire, that was believed to be so poisonous...it turned the area around it into a sickly swamp. The god of power built his forge in the world of Ambrosia, where it was eventually worshipped by the inhabitants and shrines were built in honor of him. The god of ice built his forge in the tropical region of Lodoria, which was believed to be so cold...it turned the entire jungle into a tundra winterland. The gods each picked a champion from these lands and spoke to them in their dreams. They were each given the location of the forges, along with instructions on how to use them. They simply had to place weapons and armor on the stone tiles around the forge. Once they speak their own names, the items will be infused with the power of the magical forges. They were to spread these arms and armor to their comrades for either protection or war. The gods then left these champions to their work. The first land to fall, would grant that god the winner of the contest. Years went on and lives were lost to the weapons forged. Some of these battles could be read in ancient texts. Some believe that the Serpent Island fell, as tales about the surface is void of civilization. Others think Ambrosia was the one that made the god of sickness the victor of the contest, as it was believed to be totally destroyed from the power of the energy weapons forged. The legend has been told from generation to generation. No one has found these forges nor learned the names of the champions chosen for this cruel game. It will forever remain a mystery.";
            }
            else if (book.BookTitle == "The Ice Queen")
            {
                book.BookText =
                    "The tale I write is by no means a fable, and I would advice one not to treat it as such. Her name comes in many forms. I will not guess at what that may or may not be. She was born within the Blood Cult that inhabits the larger of islands in the Isles of Dread. She was born with flesh the color of snow, and the eyes which felt like piercing flesh when they stare upon you. Those that looked upon her remembered tales of such a girl, who was to be born and perform something grand. Nobody was sure what it was, but the many tomes of the cult were consulted. It took years to read through scrolls, parchments, tablets, and books. She was only 14 when they found a scroll that told of her coming. The prophecy written stated that she would destroy the cult and banish the Blood Goddess back to the realm of demons. It was decided that she would be put to death before any of this were to come to be. They dragged her to the altar, tied her to it, and summoned the demon that would take her soul to the underworld. As the demon went to grab her from the altar, she screamed. Her scream was loud and made the jungle animals flee in terror. The scream froze the demon in a block of ice, where it then shattered in many pieces around her. Her bounds were also frozen to the point they crumbled when she tugged on them. She stood tall on top of the altar and screamed at the followers who came to witness her demise. Many escaped, but many suffered the same fate as the demon just moments prior. She fled to the tropical island to the north with nothing but a small raft. She found a cave there where she took shelter for days, eating roots and berries she foraged. As she aged, so did her power. The island was slowly turned into a frozen tundra. The cave she lived in had walls of ice, building smoothing hallways. She magically constructed golems of pure ice to patrol her corridors. Now she sits within her throne room, plotting on the cult she is destined to destroy.";
            }
            else if (book.BookTitle == "Luck of the Rogue")
            {
                book.BookText =
                    "Luck is one of the cosmic riddles that wizards and sages cannot seem to comprehend. Neither magic or divine intervention, luck is the embodiement of chaos. You can have either bad luck or good luck. One can become enriched with luck by finding magical items that seemed to have the rabbit's foot rubbed against them. I myself seem to be abundant in luck, but what does it mean to be lucky in this realm? The other adventurers I travel with do not seem to find the wondrous objects I have come across, either slaying mighty beasts or finding lost treasure. This infuriates them to be sure. I also seem to be able to avoid traps at times, where my comrades did not. I won't lie, but the separation of our bounty is a great benefit during such misfortunes. So I do not know what brings luck to some and not to others, but I find I am more prosperous because of it.";
            }
            else if (book.BookTitle == "A Tattered Journal")
            {
                book.BookText =
                    "- Autumn the 3rd - It was decades ago, but the burned memory makes it feel like yesterday. The entire city of was burned to the ground from that mighty dragon, and my family with it. I hunted it for years, never finding a trace of it. Five years ago, I heard a drunken guard babbling in the tavern about some wizard that captured the beast and sealed it within a crystal orb. They could not best the creature so they chose this course to ensure Sosaria would be safe. Although I would applaud the mage, vengeance was robbed from me. - Autumn the 20th - I found out who the wizard was and I went to see him in Montor. When I got there, the word was he met his end when looking for ancient texts in the bottom of Dungeon Clues. Before his brother could arrive in Montor to claim the wizard's belongings, I snuck into the home and stole the orb. I could see the dragon held within it, but I have much work to do if I am to get it open. - Autumn the 42nd - I have the few diamonds I need, along with the mandrake roots. I am not sure how, but looking at the orb long enough showed me the various items I need to help break the spell. I am off to buy a fur cloak, as I need to find the horn of the frozen hells now. - Autumn the 70th - I barely survived, but I finally got the eye of plagues. I am resting at the inn here in Springvale, and I will remain here for a few days to allow my wounds to heal. Why I know this, I am unsure, but I need to take this crystal prison to the Dungeon Destard. I think this is where the wizard trapped the dragon and thus needs to be release in the same area. - Winter the 5th - I failed. I unleashed the beast from its magic cage and I could not slay it. The battle was long and I had to run and hide at one point. When I returned, the dragon was gone. I fear that I may never get my chance for revenge, but I will keep searching. I will search until there is no life left from him or I.";
            }
            else if (book.BookTitle == "The Curse of Mangar")
            {
                book.BookText =
                    "Long ago, when magic still prevailed, the evil wizard Mangar the Dark threatened a small but harmonious country town called Skara Brae. Evil creatures roamed beneath Skara Brae and joined his shadow domain. Mangar surrounded Skara Brae in a spell of Voided Death, totally isolating Skara Brae from any possible help. Then, one night the town militiamen all disappeared. Only those that were within the town known of this fate. Others in Sosaria see nothing but an island full of ruins that was once Skara Brae. This was Mangar's plan all along. He wanted all to think Skara Brae was destroyed, so no one would come to oppose him. The future of Skara Brae hangs in the balance. No one is left to resist. Only a handful of unproven young warriors, junior wizards, a couple of bards barely old enough to drink, and some out of work thieves. I was there. I was the leader of a ragtag group of freedom fighters. We tried to defeat Mangar, but he is too powerful. Just when we thought we had him, he vanished in a puff of smoke, proclaiming to return. This was enough to weaken the magic of the Voided Death. A portal opened, but only for a short time. We entered the portal and returned to Sosaria, appearing on top of a tower that Mangar had built there. Be warned, this tower has allows Mangar to travel between Skara Brae and Sosaria. If one is not careful, they might touch the crystal ball that would trap them in Skara Brae.";
            }
            else if (book.BookTitle == "The Times of Minax")
            {
                book.BookText =
                    "The Stranger didn't have the task to save Sosaria, but instead Earth from the Enchantress Minax. Being the lover and apprentice of Mondain, she was quite angry over his death by the Stranger's hand, and swore revenge. Manipulating the timeline to this end, she let Earth die in an atomic holocaust in 2111 - all life on Earth perished in the aftermath. The Stranger, having escaped from the changes in the timeline at the last moment, had to decipher the mystery of the Time Doors, which enabled time travel, to reach Minax and prevent those horrible events from ever happening. Gathering the only weapon that could kill Minax, the Quicksword Enilno, and wearing the protection of the Force Field Ring, the Stranger traveled back to the Time of Legends and confronted Minax in her castle to kill her. With her death, the timeline returned to normal, with no one remembering the horrible events that occurred in the changed timeline...all except the Stranger and myself.";
            }
            else if (book.BookTitle == "Rangers of Lodoria")
            {
                book.BookText =
                    "Rangers from the land of men tracked dark elves back to their homeland. Thinking the world of Lodoria was tainted with these evil fey, the rangers set forth to rid the world of them. Their many moons of hunting had led to an encounter with the surface elves, which portrayed a more benign presence that the rangers were familiar with. This was the beginning of an alliance with the rangers and the elves of Lodoria, where ridding the world of evil was the quiet war waged above and beneath the surface. The rangers built their fort in the mountains near the City of Lodoria, that seems only reachable by a cave as black as the dark elves' skin. One would surely get lost within, but one from the ranger outpost could find their way down from the mountain and thus learn the way back up. Although the druids magically transported the rangers to the top of the mountain, the legends tell of a great hall known as Undermountain that has been long sealed and thus abandoned. If I could find my way to Undermountain, I may be just under the ranger outpost. I will start my search in that cave just north of my camp. The one infested with lizards and snakes.";
            }
            else if (book.BookTitle == "Gem of Immortality")
            {
                book.BookText =
                    "When the Gem of Immortality was shattered by the Stranger, three shards of it went missing. Each of the shards opposed one of the principles of truth, love, and courage. The shards ended up in Ambrosia and were lost until the ship 'The Ararat', under Captain Johne, was sucked into the whirlpool. Johne found the shards, and they drove him to temporary madness. He slew his three companions, and their blood fell on the shards. From it, the Shadowlords were born - Astaroth, the Shadowlord of Hatred. Faulinei, the Shadowlord of Falsehood. Nosfentor, the Shadowlord of Cowardice. They wasted no time in spreading their evil throughout the lands and have taken over the elven castle of Stonegate as their lair. If I am to rebuild the gem, I need to get these shards from the Shadowlords. I tried to slay them but they refuse to perish as the essence of immortality courses within them. I will need to find the Candle of Love to slay Astaroth, the Book of Truth to destroy Faulinei, and the Bell of Courage to defeat Nosfentor. The problem I face is that these items can be in any dungeon in the realms. I have no choice but to seek them out. They are not of this world and one could claim it again. If this happens then the one I possess will simply vanish from my grasp. When I find one, I must quickly see to its purpose. As long as one in my group holds the item, we can slay the Shadowlord and then obtain the shard from them. When I finally get all three, I will need to find King Wolfgang's tomb and speak the same words he used to construct the gem, 'Cryst An Immortalis'. I heard he was buried in Britain, but no one knows where he lies. Time is of the essence, as whoever constructs the gem first will cause all shards to vanish. The gem is too important to lose from delay.";
            }
            else if (book.BookTitle == "The Gods of Men")
            {
                book.BookText =
                    "Superstition and magic govern the lands, not kings. No matter where I travel, men follow the gods they know and the ones they grew up with tales of deeds and might. Although I did not believe in the concept of deities, the story I am about to tell is true. I heard rumors of magical scrolls contained within the halls of Doom. These tales were too hard to resist as many men have told the same tale. The chance they were to tell the same lie is slim, so I made my way south to search for myself. I thought the chambers would be void of life but I was later surrounded by the most hellish of creatures. My mystical words were not quick enough as a skeleton put their scimitar into my back. I found myself standing there, looking upon my impaled body. The creatures did not attack me, nor my lifeless body. I tried to escape through the door, but I could not touch it. My hands passed through it. I walked through the thick wood and made my way to the surface of the land. Everything looked gray to me. All matters of forest creatures did not react to my presence. I found myself drawn to something. I wasn't sure what it was, but I followed this feeling I had. It led me to an old shrine in the woods. It was a small stone pillar. In front of it were various items worshipers left for the god whose name was carved into the rock. I then heard a voice from above. I could not see who was speaking, but the voice echoed loudly in my ears. Whoever it was, they offered to bring me back to the land of living. It was then that I realized I was dead. They asked for only a small sacrifice of my wealth to show that there is more to life than mere gold. I gladly accepted as I was not ready to leave this world. I found myself, whole, in front of the shrine. Colors returned to my vision and I could feel the grass under by bare feet. I returned to Montor and grabbed some supplies from the bank. I went back to Doom and used an invisibility potion to creep around. I found where I fell in battle, my belongings still strewn about. I grabbed what I could carry and quickly left before the potion's effect was gone. I have found many of these shrines since. Some look like ankhs, while others are statues of beautiful women. I once found an altar in a cave as well. I sometimes see knights drop the gold they found at these shrines. No one takes it, as they would be surely cursed if they do. I now believe in the gods, as they spoke to me.";
            }
            else if (book.BookTitle == "Castles Above")
            {
                book.BookText =
                    "I thought it was a lone storm cloud in the distance. When no rain or thunder came, my attention was drawn further. It was a castle, high above the ground. I kept watching to see if it would fall, but it never wavered. I decided to approach it and try to get below it. That is when I found the blue magical lantern. Within its glow was a rope that ascended to the heavens. I used all of my strength and climbed the rope, finally reaching the castle above. I knocked on its thick wooden door, and an echo bellowed from within. On the third knock, the door pushed open just a bit. It was hard to open as it was old, warped, and probably hasn't been open for many years. The interior of the castle was dusty and void of life. The halls and rooms were empty of any treasure. If I had the gold to furnish this place, I would make it my home. I wonder what manner of wizard abandoned such a home? Did they live here for years, only to return to the surface and live among others?";
            }
            else if (book.BookTitle == "Staff of Five Parts")
            {
                book.BookText =
                    "Legends say it was too powerful. It was said that Merlin was slain by one wielding it. The Staff of Ultimate Power was broken into five parts by the gods, where they were given to guardians for protection. If one proves themselves worthy to the Time Lord, they may one day assemble the staff as he was overseer of the guardians. The pieces can only be assembled next to the molten core of the Moon, where one must sit on the stone throne and speak the words that will assemble the power. The core is where no one could survive, but if one stays on the rune marked path they should be safe from the heat. The staff will bind to the one who assembles it, where no other may wield it. If anyone else were to attempt to hold it, the magic would be drained from the staff where it would simply be a useless stick forever. Only one unique piece may exist in this realm at a time. So if a guardian is slain, the slayer will acquire the piece they protect and all other pieces of that kind will vanish out of existence. The staff will appear in either a staff of wizardry, a staff of necromancy, or a staff of elementalism. This would depend on which magic is stronger in the one that sits on the throne and speaks the words. I have yet to find the words to speak, and other events have led me to learn that the fifth guardian escaped the Time Lord's realm. Xurtzar, of demonic energy, escaped so only four remain under the Time Lord's care. No one knows what became of Xurtzar, as he opened a moongate to the Serpent Island and fled. So now I sit and try to think. Where did Xurtzar flee to? Where can I find the words to speak? I must become the most powerful wizard in Sosaria. I must if I am to defeat Mangar the Dark.";
            }
            else if (book.BookTitle == "The Story of Exodus")
            {
                book.BookText =
                    "No one in all of Sosaria, not even the Stranger, could have realized that by ending the lives of Mondain and Minax, the Stranger would be orphaning their only child. The name of this unusual child was Exodus, and he was neither machine nor human. Exodus rose from the bottom of the Great Ocean to carry out a campaign of revenge and destruction against the land of Sosaria. So terrible were the forces unleashed by Exodus that the hero whom we would come to know as the Stranger required the assistance of a mysterious being known as the Time Lord to thwart them. And thus it was that the Stranger did deal with Exodus in a similar manner as he had dealt with his mother and father. Since that time much speculation has been given to the potentially immeasurable good such a creature as Exodus could have brought the land had he been persuaded to become beneficent, but I wish to formally disagree with those who say the Stranger should have handled the situation differently.";
            }
            else if (book.BookTitle == "The Story of Minax")
            {
                book.BookText =
                    "The triumph of the Stranger did not last long, for in slaying Mondain he brought the wrath of Minax down upon the land. Minax was the young lover of Mondain and a sorceress with magical powers even greater than Mondain's. She had the power to command legions of foul creatures, and in her quest for vengeance over the death of her lover, she brought much misery to the people of Earth. Again the hero who would come to be known as the Stranger, took up the fight as Earth was his home world. The Stranger slew Minax's minions and did eventually destroy her as well. While there have been speculations as to the motivations of the Stranger, there is insufficient evidence to show that the Stranger was driven to violence by jealousy over Mondain's romantic involvement with Minax. That being said, such theories are hereby denounced and should not be given consideration.";
            }
            else if (book.BookTitle == "The Story of Mondain")
            {
                book.BookText =
                    "The beginning of the First Age of Darkness was marked by the coming of a sorcerer named Mondain. The father of Mondain had refused to share his secret of immortality with his son, and their disputes ultimately led to the father's death. Torn with anguish and no doubt by his fears of persecution, Mondain turned his dark powers against the kingdoms of Sosaria. In desperation, Lord British called forth a champion to rise to the defense of the realm. The hero who responded to his summons would many years later come to be known as the Stranger. It was through the actions of this Stranger that Mondain's foul gem of power was shattered and Mondain himself did come to a very sad end indeed.";
            }
            else if (book.BookTitle == "The Bard's Tale")
            {
                book.BookText =
                    "The song I sing will tell the tale of a cold and wintery day. Of castle walls and torchlit halls and a price men had to pay. When evil fled and brave men bled the Dark one came to stay. For men of old for blood and gold will rescue Skara Brae.";
            }
            else if (book.BookTitle == "Death Dealing")
            {
                book.BookText =
                    "I pity those that fear death. There can be great power if you face the Reaper's stare, but most cannot perform such a feat. Many feel that this course is nothing but evil, wretched practices. Every creature has an essence that can be harnessed after death. We just learned how to gain power from it. We also learned spells requiring minor things like grave dust or pig iron. When people do not understand such things, they are afraid of it. That is what drove most of us from the cities and villages. No matter, it is easier to practice such magics in the absence of light. The elders saw this centuries ago and built their city of Umbra within the volcanic mountains of Sosaria. If one can find it, they can practice these arts with no scrutiny from others. It would shock one to look upon it for the first time, as those that lived there their whole lives have flesh as pale as the bones of the dead. Some of us have even constructed our strongholds within the mountain halls of blackened rock. It is a glorious time to be dead, as long as its not me.";
            }
            else if (book.BookTitle == "The Orb of the Abyss")
            {
                book.BookText =
                    "The Underworld is an unusual place for our order. Although I have heard tales of necromancy and holy magics working in the dark depths of that abyss, I find my magery spells failing too often for my travels to be relatively safe there. Even my magery scrolls and wands seem to fail too often. Those that dwell there, seem to have no obstacles in unleashing magery spells. If I am to pursue the titans below, I will need to be at my full potential. Tales tell of the Codex of Ultimate Wisdom, that anyone who holds the book will have no such difficuly with magic. That, however, is too far beyond my reach as it is said to be somewhere in the Ethereal Void. My next destination then is the dungeon of Hythloth where my research has shown that the Orb of the Abyss lies in wait. Wizards that hold this orb are able to cast their magery spells when in the Underworld. Legends even tell of wizards from centuries ago needing this orb when the ancient forgotten spells were used in these depths. The orb, however, is guarded by a great evil. Ancient scrolls tell of a portal that will lead to the domain of Satan himself. The room is said to be hidden, but I have magic that will aid me in its location. The portal does not let anyone pass, but only those that know the true name of the devil that lurks on the other side. If the sage in "
                    + RandomThings.GetRandomCity()
                    + " speaks true, then 'Lucifer' is the devil's name and I will need to shout it when I find the hellish gate. I must first go to "
                    + RandomThings.GetRandomCity()
                    + ", where I am hoping to find allies for the coming battle.";
            }
            else if (book.BookTitle == "The Underworld Gate")
            {
                book.BookText =
                    "There are legends of a place darker than the veil covers the sky at night. A world that never sees the sun and the vilest dwell. The likes of man would never want to witness such things, but the brave and adventurous seek this realm for the rumors of riches that lie within. The Underworld is in fact, real. Many years ago, monsters poured out from the cave that leads to this abyss and filled the lands with terror and destruction. Lord British and Baron Almric joined forces and lead a campaign across the entire world, pushing most of them back into the Underworld. Once done, Almric used a long lost spell to seal the entrance, locking them below the land of Sosaria forever. Now a large stone blocks the way, covered in magical runes that only Baron Almric can open. But the Baron was slain by the Slasher of Veils, in a futile attempt to rescue his daughter. Although he managed to reach the land before falling to his doom, it is undetermined where he was laid to rest. Some believe that he is buried near "
                    + RandomThings.GetRandomCity()
                    + ", but there are rumors that he was taken back to his wife’s home of Skara Brae. If the death from the Slayer did not resurrect his corpse to wander the land, one must only find his tomb and retrieve his head. Presenting it at the great runic gate may break the spell and open the seal to the Underworld. One must beware the Underworld, however, as ancient text states that wizardry is hindered when traveling the abyss.";
            }
            else if (book.BookTitle == "The Elemental Titans")
            {
                book.BookText =
                    "The early days of the Obsidian Fortress were a dark time. The blood from the wars flowed freely as the Drow fought Zealan in the grand struggle of religious cleansing. Battles were planned and executed. Lives were lost all in the name of archaic beliefs. All the while, the Drow toiled daily to construct the Obsidian Fortress, as commanded by the benevolent being called the Guardian. The fear of the Destroyer was strong.<br><br>Years of sweat ultimately resulted in the completion of the Fortress. There the Drow wizards met to focus their energies into the worship of the Elementals. Tremendous magical forces were used to collect a strange black mineral and shape it into a large, dark obelisk. From inside the Fortress, the followers channeled their thoughts through the obelisk to the four elements, giving them even greater power. Soon they had amassed enough energy to become the great Titans of Earth, Water, Air, and Fire.<br><br>The war continued, but now the Drow had considerable assistance. Lithos moved the lands to trap the Zealans, while Hydros removed her waters from their reach. Pyros' fires raged and grew, fueled by the winds of Stratos. It was only a matter of attrition before the Zealans and their petty beliefs fell. Then came the Guardian's final words of warning: 'Take your people and depart from the Fortress. The Destroyer has come.' As the Drow left the Fortress, the Guardian attempted to destroy the Fortress. The Drow pleaded for the aid of the Titans. They were not disappointed. The four Titans appeared to challenge the Guardian. The land was all but destroyed as rock, rain, wind, and fire hailed down from above. The battle was long and fierce. Finally, however, the Titans returned victorious. The land, though scarred from the terrible fight, was still theirs. The Guardian had fled the Underworld, forever.<br><br>The great battle broke five pieces off the obelisk. The first fragment, called the Heart of Earth, was linked to Lithos, the Titan of Earth. Hydros, the Titan of Water, was linked to the Tear of the Seas. The third fragment, the Breath of Air, was linked to Stratos, the Titan of Air. A fourth fragment was linked to Pyros, the Titan of Fire. There is considerable speculation about a fifth fragment. Apparently the tip of the great obelisk was seen hurling through the air almost entirely intact. However, no one ever saw the item land, so its location remains a mystery. Were all of the fragments to be gathered together and taken to the Obsidian Fortress, it might be possible to create a separate obelisk. Of course, it to would still be necessary to fabricate a magical field of some sort to channel the energy from whatever source first gave the obelisk power. Some believe a great Zealan warrior, Khumash-Gor, found the Obelisk Tip. This is probably just legend as Khumash-Gor died centuries ago, during the great Underworld war.<br><br>Collecting the pieces of blackrock is something mere men will never achieve. Without the Obelisk Tip, a mortal man cannot even move the other pieces of blackrock. If one were to find this lost relic, they would possess the means to one day become a powerful Titan of Ether..";
            }
            else if (book.BookTitle == "The Dragon's Egg")
            {
                book.BookText =
                    "Dwarves are a proud people, and we have made many mountains in Lodor our home. It saddens the heart to see my people fall to this blight that has spread from north to south. We are dying, and the oldest and wisest of us cannot determine the cause. It feels like a disease, but herbalists are unable to cure it. Those with magic tried, but died in the attempt. We are cursed and we will soon be no more.<br><br>Many of our homes are becoming inhabited with demons or the dead. Those that made the armor and weapons of our clans are no more. Only a few of us remain and we huddle together in hopes of avoiding the fate of others. I was a dragon master, which was a special skill before the likes of elves became civilized. Before the elves were able to tame such beasts, we dragon masters would find the eggs of great dragons or wyrms. We would collect what was needed to ensure it could hatch. With dragon masters being the first one sighted by the beasts, they would quickly follow our lead and treat us as if we were their mothers. They would fight with us against the legions of the dead, and the foul dark elves that come to our domains.<br><br>I remember learning the mastery of dragons at a young age. My father would slay a mighty dragon and bring the egg home to my mother. In order to see if a dragon was alive within it, we had to take the egg to the lava pool in the Dwelling of Rhundar. Rhundar was home to the most notable crafters, and the light from the pool was so bright that we could see through the mighty shell of the eggs. Now Rhundar lies in ruins as the dead have destroyed all that lived there. Now we just call it Deceit, as not to remind ourselves of the greatness it once was.<br><br>Once we saw a living dragon within, we had to brew the potions of the four elements and apply the liquids to the shell. Then it would soften so the baby dragon could break free. The combination of the potions caused the young one to develop quickly upon birth, which made them favorable companions immediately. I had many dragon pets, but we could not keep them after the plague started. We set them free, where most of them sought shelter in Destard. I will miss these days, and it saddens me that I will not have children to teach this to.";
            }
            else if (book.BookTitle == "Magic in the Moon")
            {
                book.BookText =
                    "It started as an orb in the sky, and we gave it the name of Luna. We would wait for the sun to set so we could gaze upon it. The moon called Luna came at certain times and we quickly recorded the different phases of the moon. This helped us discover the many affects the moon has on Sosaria. The necromancers learned that when the moon was at its fullest, that the lycanthropes would be the most prominent and powerful. The sorcerers learned that the magic gates throughout the land would lead to different places based on these phases. This is when we started calling them moongates. The moon holds so much magical power, that the most wise of us gathered daily to craft a spell powerful enough to help us reach the celestial object.<br><br>After almost 20 years of research, we found a way to take the power of a single moongate and hold it within a small mystical orb that was crafted of meteoric glass. This had the effect of draining magic from the moongates, to the point where one can now control where they are led if they step into one and they know where to go.<br><br>We took this captured magic and placed the orb on the pedestal of the Shrine of Wizardry. We then took our first steps to the moon. The planet was small, gray, and cratered but spacious to build castles and villages, so we built our city of Dawn.<br><br>With the aid of conjuration, Luna was built in just ten revolutions around Sosaria. We had a place to safely research our magic, and no longer had concerns of wizardry being accidentally unleased on Sosaria.<br><br>We tried to bring visitors to the moon, but the sheer power of the lunar surface rejects those that are not powerful enough with such energies. So this has been our home for wizards, witches, warlocks, and sorcerers. The guildmasters found an asteroid nearby, and built our main guild hall there. This has worked well with recruiting apprentices, as those weak with magic are able to travel to the asteroid to begin their studies. One day, they will be able to come to the moon and perhaps build a home of their own.";
            }
            else if (book.BookTitle == "The Maze of Wonder")
            {
                book.BookText =
                    "Before the darkness filled King Durmas IV, he was a wise and kindly ruler. Most forget the tales of his exploits against evil, and the joy he brought to his subjects. He was a creator of art and beauty, and this is still seen today within his hedge maze. The King’s tomb lies within the maze, but the evil has not surfaced enough to corrupt the maze entirely. The glory of the maze remains but be warned that creatures now traverse the maze. The cursed men were turned into minotaurs that guard the tomb, while some continue to live within it as a means of solitude from the world. If you are brave and mighty enough, it is something that should be toured. The King built it as a pleasant way to reach the lively tavern in the center, but now it holds a dangerous beauty that most people fear.";
            }
            else if (book.BookTitle == "The Pass of the Gods")
            {
                book.BookText =
                    "Where dwarves were once the master crafters of the world, their extinction was followed by the art of our elven lands. We elves create unique and unusual items, and decorate them in lavish colors. Our pursuit of fine crafts led some of us on a journey to far off valleys. They sought the highest peaks in the lands as they thought that being close to the gods would provide tutelage in the creation of items fit for deities. Their journey brought them to the ork lands of the Savaged Empire, where they found the very mountain they only witnessed in their dreams. Our brothers and sisters never returned to the world of Lodoria, but many try to find the path of their pilgrimage. Perhaps they too can learn of celestial guided crafting themselves.";
            }
            else if (book.BookTitle == "Valley of Corruption")
            {
                book.BookText =
                    "Our order is guided by the very principle of nature, neutrality, and the natural order of things. We see a balance in the world that must be protected and maintained. In recent years, this principal has become slowly corrupted by vile forces we have yet to understand. Some of our brothers and sisters have left our order, in pursuit of evil. What corrupts their minds is that of power over others. They no longer care for the balance of the world, but their own greed.<br><br>This was most evident on the island of Kuldar. That baneful wizard Vordo convinced the local druids to join his legions of magic users, and then the demons and corrupt satyrs joined the ranks. We were to deal with this growing threat, but when we sailed to the island, it was gone. We sailed the seas for days thinking we perhaps had the wrong coordinates, but it as if it never existed. We returned home, with no further rumors of Vordo or his evil druids. Some say that Vordo unleashed a spell that doomed them all, sinking the island to the bottom of Neptune’s depths. We will never know what really happened, but the lands are safe from that dark wizard. Balance had been restored.";
            }
            else if (book.BookTitle == "The Demon Shard")
            {
                book.BookText =
                    "For centuries, warlocks would often tempt daemons to visit this realm and trap them within pentagrams of immense power. Their goal was simple, enslave a daemon to do the bidding of the warlock. In order to transport these daemons from the pentagrams, they would have to trap them within shards of avarnium crystal. Ancient wizards would sometimes have these shards, but they are either long dead or joined the ranks of the dead. I found such a crystal, and I hope to learn the secrets of shard. I learned that if I can free the daemon, they would owe me a life debt for their freedom, and would accompany me without restraint. I know I have to find some shards of power in order to meld them with this crystal and would thus shatter.<br><br>I will consult the sages to learn the location of these other shards, but I need to know what type of daemon I am dealing with. I found an ancient scroll that gives me a clue. If I can make it to the Isles of Dread, and commandeer a ship, I can sail to the island where the Blood Temple lies. There I should be able to remove the first protective magics that cover this shard in secrecy. There, I should find the vortex of blood and stand within it. Then using the shard should nullify that spell so I can see within it.";
            }
            else if (book.BookTitle == "The Syth Order")
            {
                book.BookText =
                    "It is said that the first of our order was the first of theirs. The castle fell from the sky centuries ago, and within those walls came the scourge of what we call the Syth. Most people believe them to be legends or fairy tales, as they make their presence known to few and those few are often looking into the eyes of the Syth for their final moments. Their motives are the most vile in nature, and perhaps could be compared with the goals of demons and devils. They wish to only create chaos where there is peace, and rule over those from the shadows. They slay those that stand in their way, and take what they want to meat their ends. They are masters of both magic and the blade, but ancient teachings have described their power of that from the mind and not from wizardry. To all that read this tome beware. The Syth are real and may you never have to face one in battle.";
            }
            else if (book.BookTitle == "The Rule of One")
            {
                book.BookText =
                    "Our mission was a simple one. Get the plans for that new space station that is being built so we can then find a weakness and strike a devastating blow for the Syth. Two of us managed to infiltrate Captain Gadberry’s ship and download the data, but his ship crashed here on this planet. After the crash, the theory traversing the decks was that a stranger took too much fuel from the main ship’s reserves. This supposedly caused the orbit to decay. We were soon discovered by security and Master Malak and I fled the wreckage and managed to avoid pursuit in the forest. We setup a beacon for evacuation, but fear that we are too far in the galaxy to have the signal picked up by our order.<br><br>We spent many years exploring the land and learning the cultures. Some of these people, often called wizards, seem to have a power similar to us. The way they call it forth, however, is more ritualistic than the sheer psychic forces we command. They use a series of herbs and trinkets, along with words and gestures to unleash these forces. Although different, they have similar effects and have often matched our own strength of will. We searched for items of similar power, in the hopes that one can get us off this rock. We never found such an item.<br><br>It was decided to increase our ranks on this planet, by finding those that have the talent to become a Syth. If we cannot leave, then perhaps we should rule. Malak decided to cultivate a relationship with a group of death knights. Ten were allowed in the Syth order, as they had similar methodologies to our own so teaching them the Syth ways was of little difficulty. We were a disease unleashed on the land, and we brought the mightiest to their knees. This, however, brought forth new dilemmas.<br><br>The death knights became hungry for power. So much in fact that they began to betray us as well as each other. Their greed is what killed my master, and fractured the collective whole. Soon the holy knights of the land hunted them down and slain each in turn. The ten followers are dead now, buried in tombs throughout the lands. I laid Malak to rest in the Fires of Hell, and built a statue in his honor. I entombed him with his datacron, which could hold the knowledge of the Syth if one seeks it. After being slain by the death knights, each of the ten took a piece of Malak’s knowledge with them. So his datacron now contains very little information and I have no desire to restore it. It is locked away, however, and I need only speak the words ‘Anakasu Arrii Venaal’ to release it from its resting place if I ever change my mind.<br><br>So now I remain, the last Syth on this primitive planet. Gadberry never repaired his ship and it was deserted the last time I went to the crash site. Ship logs showed that the survivors went off to settle the land and live out their lives. I grow weary and old, but I did find an apprentice to pass my knowledge to. I will instill the rule of one, where only one Syth should be. Any more than one could lead to the destruction of the order in its entirety as greed and power will cause us to kill each other to be the ultimate ruler. Once I feel they are ready, they will help me end my life and pursue their own agenda until they need to pass on their knowledge to another. They will need to begin learning the concepts of psychology (10 points at least) and have negative karma if they ever want to claim Malak's datacron. They would then need to master the skills of swords and tactics if they wish to have the most power at their fingertips. I will rest now, and I'll see how they do.";
            }
            else if (book.BookTitle == "Antiquities")
            {
                book.BookText =
                    "Rare items are a goal for most collectors of the land, as I myself could pay plenty of gold for something that is unique. My days of exploring the dreadful dungeons is long past, but other brave souls manage to bring back items long forgotten in the dingy hallways of the abandoned dwellings where evil commonly lurks. One may find some unusual weapon or armor that is no longer usable, but can be decorative for a wealthy home or castle. Other rare items could be found in the forms of leather, furs, cloth, liquors, reagents, jewelry, or mystical items from long dead wizards. Others may be decorative clocks, vases, statues, or paintings of people and scenery from long ago. These items are often kept by adventurers as trophies for their adventures. Others would rather barter for gold of such items. One that is good with item lore can usually determine the value of such items, and who in the settlements may want the items. Those that are not good at item lore or identification can usually guess who may want the item. These items cannot be simply sold to these collectors, but instead one would just give them the item and the citizen will give them an appropriate amount of gold. Usually those skilled in mercantile will get more gold than the average adventurer, but the value can still be great. So if one wishes to carry out such treasures, they can surely increase their wealth from just the coins they may hoard.";
            }
            else if (book.BookTitle == "The Jedi Order")
            {
                book.BookText =
                    "This world is not my home. That lies far away in the Corusant system, of the Zeta Quadrant, among the stars. When Gadberry's ship crashed, I was stranded here along with everyone else. We were not alone on that ship, however. The Syth came aboard at some point, and they were attempting to steal critical data from the computer system. Although they succeeded in their efforts, it turned out to be futile as they could not escape anymore than I. The Syth fled from the ship, and the crew sought my council on this vile cult of psychics. I gave chase into this strange world, but never found a trace of them. I vowed to never return to the ship until I found the Syth and dealt with their treachery. As the years carried on, I learned more and more of this world. The strange creatures and the humanoids with powers similar to mine, all became a normal affair to me.<br><br>I still believed the Syth were out there, plotting. I decided to teach the Jedi way to those that have the psychic potential of psychology in others. Some learned quickly, where others could not fully grasp the teachings. Those that joined the order did battle the Syth, but they were Syth of this world and not of the ones that crashed here with me. This means that they were gathering followers. This secret war waged on and we began seeing less and less Syth in the land. We may have defeated them, on this planet at least.<br><br>As the peace settled in, much of our new order slowly joined civilization. Although I know them by their Jedi names, they embraced new names for themselves and became priests in the many villages of the realm. I approved of this life, as it was a noble end to their lives. These ten Jedi were keepers of a holocron of wisdom for a particular Jedi power. If time was to catch up with them, I asked only they take their holocron to their final resting place. Anyone that presents themselves to learn the Jedi way, will learn of these secrets from my resting place. I chose a cave far off to the east of Britain, where Jacen is instructed to lay me to rest. If one is worthy of this path, they need only speak 'Oh Beh Wahn' at my tomb and they will get the wisdom I will pass to start their journey. If the Syth return, then the Jedi must as well.";
            }
        }
    }
}
