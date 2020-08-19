using Microsoft.EntityFrameworkCore.Migrations;

namespace BeastMaster.Migrations
{
    public partial class BuildDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 1,
                columns: new[] { "CreatureAbility", "CreatureDescription", "CreatureHabitat", "CreatureImage", "CreatureLifespan", "CreatureMorality", "CreatureName", "CreatureNemesis", "CreatureOriginCulture", "CreatureOriginDate", "CreatureRelatedCreature", "CreatureTaxonomy", "CreatureType", "CreatureWeakness" },
                values: new object[] { "Eats Souls of the wicked", "If the heart was judged to be not pure Ammit would devour it and the person undergoing judgment was not allowed to continue their voyage towards Osiris and immortality. Once Ammit swallowed the heart the soul was believed to become restless forever this was called to die a second time.", "near the scales of justice in Duat the Egyptian underworld", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/ammit.jpg", "Eternal", "personification of divine retribution", "Ammit", "none", "Pharaonic Egypt", "none", "none", "Animal Demoness", "Demoness", "None" });

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "CreatureId", "CreatureAbility", "CreatureDescription", "CreatureHabitat", "CreatureImage", "CreatureLifespan", "CreatureMorality", "CreatureName", "CreatureNemesis", "CreatureOriginCulture", "CreatureOriginDate", "CreatureRelatedCreature", "CreatureTaxonomy", "CreatureType", "CreatureWeakness" },
                values: new object[,]
                {
                    { 27, null, "In Greek mythology and later Roman mythology the Cyclopes Circle-eyes or Round-eyes1 singular Cyclops are giant one-eyed creatures.2 Three groups of Cyclopes can be distinguished. In Hesiods Theogony they are the brothers: Brontes Steropes and Arges who provided Zeus with his weapon the thunderbolt. In Homers Odyssey they are an uncivilized group of shepherds the brethren of Polyphemus encountered by Odysseus. Cyclopes were also famous as the builders of the Cyclopean walls of Mycenae and Tiryns.", null, "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/cyclops.jpg", null, "evil", "Cyclops", null, "Greek", "1st century", null, "One Eyed Man", "Human Giant", null },
                    { 28, "firebreathing flight", "Commonalities between dragons traits are often a hybridization of avian feline and reptilian features and may include: snakelike features reptilian scaly skin four legs with three or four toes on each spinal nodes running down the back a tail and a serrated jaw with rows of teeth. Several modern scholars believe huge extinct or migrating crocodiles bear the closest resemblance especially when encountered in forested or swampy areas and are most likely the template of modern dragon imagery.12 This also fits with the ancient words Draco and Drakon meaning large serpent or sea serpent.", "cave", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/dragon.jpg", null, "neutral", "Dragon", null, "English", "13th century", "drake/wyvern/snake/reptile", "Serpent", "serpent", null },
                    { 29, "flight/small magic", "Fairies are generally described as human in appearance and having magical powers. Diminutive fairies of various kinds have been reported through centuries ranging from quite tiny to the size of a human.7 These small sizes could be magically assumed rather than constant.8 Some smaller fairies could expand their figures to imitate humans.9 On Orkney fairies were described as short in stature dressed in dark grey and sometimes seen in armour.10 In some folklore fairies have green eyes. Some depictions of fairies show them with footwear others as barefoot. Wings while common in Victorian and later artworks are rare in folklore fairies flew by means of magic sometimes perched on ragwort stems or the backs of birds.11 Modern illustrations often include dragonfly or butterfly wings.12", "forest", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/fairy.jpg", null, "culture dependant", "Fairy", null, "none collective", null, null, "humanoid", null, null },
                    { 30, "earth bending", "The chthonic or earth-dwelling spirit has precedents in numerous ancient and medieval mythologies often guarding mines and precious underground treasures notably in the Germanic dwarfs and the Greek Chalybes Telchines or Dactyls.", "caves", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/gnome.jpg", null, "good", "Gnome", null, null, "1566", "goblin", "humanoid", "small humanoid", null },
                    { 31, "various", "A goblin is a monstrous creature that appears in the folklore of multiple European cultures first attested in stories from the Middle Ages. They are ascribed various and conflicting abilities temperaments and appearances depending on the story and country of origin. They are almost always small and grotesque mischievous or outright malicious and greedy especially for gold and jewelry. They often have magical abilities similar to a fairy or demon. Similar creatures include brownies dwarfs duendes gnomes imps and kobolds.", null, "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/goblin.jpg", null, "evil", "Goblin", null, "European cultures", "1195", "hobgoblin", "various/humanoid", null, null },
                    { 32, "can turn people into stone", null, null, null, null, "evil", "Gorgon", null, "Greek", "600 bc", "human/reptile", "humanoid/reptile features/horns", null, null },
                    { 33, "mechanical disruption", "A gremlin is a folkloric mischievous creature that causes malfunctions in other machinery. Depictions of these creatures vary. Often they are described or depicted as animals with spiky backs large strange eyes and small clawed frames that feature sharp teeth.", "machines", null, null, "evil", "Gremlin", null, "North American", "1940's", null, "Hybrid/humanoid/animal", null, null },
                    { 34, null, null, "Mountains", null, null, null, "Griffin", null, "western Asia and into Greece", null, null, null, null, null },
                    { 35, "flight", "The harpies seem originally to have been wind spirits personifications of the destructive nature of wind. Their name means snatchers or swift robbers10 and they steal food from their victims while they are eating and carry evildoers especially those who have killed their family to the Erinyes. When a person suddenly disappeared from the Earth it was said that he had been carried off by the harpies.11 Thus they carried off the daughters of king Pandareus and gave them as servants to the Erinyes.12 In this form they were agents of punishment who abducted people and tortured them on their way to Tartarus. They were vicious cruel and violent.", "Cave", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/harpy.jpg", null, "evil", "Harpy", null, "Greek", null, "human/bird", "Hybrid/Female/Bird", "Hybrid/Female/Bird", null },
                    { 36, null, "In the 1930s Douglas Herrick and his brother hunters with taxidermy skills popularized the American jackalope by grafting deer antlers onto a jackrabbit carcass and selling the combination to a local hotel in Douglas Wyoming. Thereafter they made and sold many similar jackalopes to a retail outlet in South Dakota and another taxidermist continues to manufacture the horned rabbits in the 21st century. Stuffed and mounted jackalopes are found in many bars and other places in the United States stores catering to tourists sell jackalope postcards and other paraphernalia and commercial entities in America and elsewhere have used the word jackalope or a jackalope logo as part of their marketing strategies. The jackalope has appeared in published stories poems television shows video games and a low-budget mockumentary film. The Wyoming Legislature has considered bills to make the jackalope the states official mythological creature.", null, "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/jackalope.jpg", null, "neutral", "Jackalope", null, "North American", "1930", "rabbit/antelope", "Hybrid/Jackrabbit/Antelope", "Hybrid/Jackrabbit/Antelope", null },
                    { 37, null, "The word Leviathan has come to refer to any sea monster and from the early 17th century has also been used to refer to overwhelmingly powerful people or things comparable to Behemoth or Juggernaut influentially so by Hobbes book 1651", "Sea", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/leviathan.jpg", null, "Evil", "Leviathan", null, "Hewbrew", null, null, "Serpent", "Serpent", null },
                    { 38, "Magic", "In fantasy fiction a lich ˈlɪtʃ1 from Old English līċ meaning corpse is a type of undead creature. Often such a creature is the result of a transformation as a powerful magician skilled in necromancy or a king striving for eternal life using spells or rituals to bind his intellect and soul to his phylactery and thereby achieving a form of immortality. Liches are depicted as being clearly cadaverous bodies desiccated or completely skeletal. Liches are often depicted as holding power over hordes of lesser undead creatures using them as soldiers and servants. Unlike zombies which are often depicted as mindless a lich is sapient retaining independent thought and is as intelligent as it was prior to its transformation.", null, "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/lich.jpg", "immortal", "Evil", "Lich", null, "English", null, null, "Humanoid", "Undead", null },
                    { 39, "Strong", "walks the Earth alone and doesnt care who you are or what you did he simply wants to get you", "Caves and Imaginationland", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/man-bear-pig.jpg", null, "Evil", "Man-Bear-Pig", "Al Gore", "America", "2006", null, "Half man, Half bear, and half Pig", "Hybrid Animal", null },
                    { 40, "Venom/Strength", "The manticore Early Middle Persian: merthykhuwar Persian: mardykhor is a Persian legendary creature similar to the Egyptian sphinx that proliferated in western European medieval art as well. It has the head of a human the body of a lion and a tail of venomous spines similar to porcupine quills while other depictions have it with the tail of a scorpion. There are some accounts that the spines can be shot like arrows thus making the manticore a lethal predator. It devours its prey whole using its triple rows of teeth leaves no traces of its victims including bones behind.", null, "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/manticore.jpg", null, "Evil", "Manticore", null, "Persian", "77 ad", "Lion/Scorpion/Human", "Hybrid/Human/Lion/Scorpion", "Hybrid Animal", null },
                    { 41, "Strength", "In Greek mythology the Minotaur Ancient Greek: in Latin as Minotaurus is a mythical creature portrayed in Classical times with the head and tail of a bull and the body of a man1 or as described by Roman poet Ovid a being part man and part bull.2 He dwelt at the center of the Labyrinth which was an elaborate maze-like construction. The Minotaur was eventually killed by the Athenian hero Theseus.", "Minoss Labyrinth, Crete", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/minotaur.jpg", null, null, "Minotaur", "Theseus", "Greek", null, null, "hybrid/bull/human", "hybrid/bull/human", null },
                    { 42, "Use pitchforks and chains to imprison the ghosts", "In their duties as guardians of Diyu the realm of the dead their role is to capture human souls reached the end of their earthly existence to bring them before the courts of Hell. Souls are then awarded based on actions performed in their lifetime.", "Diyu", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/ox-head-and-horse-face.jpg", "Eternal", "Neutral", "Ox-Head and Horse-Face", "Monkey King", "Chinese", null, null, "Human Animal", "Mythical Guardian", null },
                    { 43, "Flying", "Pegasus allowed Bellerophon to ride him in order to defeat the monstrous Chimera which led to many other exploits. Bellerophon later fell from the winged horses back while trying to reach Mount Olympus. Afterwards Zeus transformed Pegasus into the eponymous constellation.", "Olympus", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/pegasus.jpg", "Eternal", "Good", "Pegasus", null, "Greek", null, null, "Hybrid Animal", "Mythical", "Pegasus is not portrayed with a weakness." },
                    { 44, "none", "A troll is a being in Scandinavian folklore including Norse mythology. In Old Norse sources beings described as trolls dwell in isolated rocks mountains or caves live together in small family units and are rarely helpful to human beings. In later Scandinavian folklore trolls became beings in their own right where they live far from human habitation are not Christianized and are considered dangerous to human beings. Depending on the source their appearance varies greatly trolls may be ugly and slow-witted or look and behave exactly like human beings with no particularly grotesque characteristic about them.", "Mountain/Cave", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/troll.jpg", null, "evil", "Troll", "humans", "Norse", null, null, null, null, null },
                    { 45, "Lives Forever and Drinks Human Blood ", null, "Living in the shadows", null, null, null, "Vampire", "Buffy, Stephenie Meyer", "Germanic", "17th Century", "Werewolves", "Vampire, Undead", "Vampire", "Sunlight, Wooden Stakes, " },
                    { 46, "lycanthropy", "In folklore a werewolfa Old English: werwulf man-wolf or occasionally lycanthrope ˈlaɪkənˌθroʊp Greek: λυκάνθρωπος lukánthrōpos wolf-person is a human with the ability to shapeshift into a wolf or especially in modern film a therianthropic hybrid wolflike creature either purposely or after being placed under a curse or affliction often a bite or scratch from another werewolf with the transformations occurring on the night of a full moon. Early sources for belief in this ability or affliction called lycanthropy laɪˈkænθrəpi are Petronius 27–66 and Gervase of Tilbury 1150–1228.", null, "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/werewolf.jpg", null, null, "Werewolf", null, "English", "15th century", "wolf/human", "hybrid/human/wolf", "hybrid/human/wolf", "silver" },
                    { 47, "magical powers", "A witch also known as a sorcerer or warlock is a person with the power to effect change by magical means aka witchcraft.", "global", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/witch.jpg", null, "Good/Evil", "Witch", null, "global", "12th century", null, "humanoid", "sorcerer", "fire" },
                    { 26, "death stare", "Arthur Fox-Davies describes the cockatrice as comparatively rare in heraldry and as closely resembling a wyvern outside of possessing a roosters head rather than a dragons. The cockatrice like the rooster is often depicted with its comb wattles and beak being of a different color from the rest of its body. The cockatrice is sometimes referred to as a basilisk but Fox-Davies distinguishes the two on the basis of the heraldic basilisk possessing a tail ending in a dragons head although he does not know of any arms depicting such a creature.15", "forest", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/cockatrice.jpg", null, "evil", "Cockatrice", "weasel", "English", "1180", "rooster/dragon/snake/serpent", "Hybrid/Dragon/Cock", "Hybrid/Dragon/Cock", "weasels" },
                    { 48, "strength/cold resistance", "The name Abominable Snowman was coined in 1921 the same year Lieutenant-Colonel Charles Howard-Bury led the 1921 British Mount Everest reconnaissance expedition1314 which he chronicled in Mount Everest The Reconnaissance 1921.15 In the book Howard-Bury includes an account of crossing the Lhakpa La at 21000 ft 6400 m where he found footprints that he believed were probably caused by a large loping grey wolf which in the soft snow formed double tracks rather like those of a bare-footed man. He adds that his Sherpa guides at once volunteered that the tracks must be that of The Wild Man of the Snows to which they gave the name metoh-kangmi.15 Metoh translates as man-bear and Kang-mi translates as snowman.241016", "mountains/snow", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/yeti.jpg", null, "Neutral", "Yeti", null, "Himalayas", null, "bigfoot/sasquatch", "hybrid/human/bear", "snow monster", null },
                    { 25, "firebreathing", "Homers brief description in the Iliad3 is the earliest surviving literary reference: a thing of immortal make not human lion-fronted and snake behind a goat in the middle4 and snorting out the breath of the terrible flame of bright fire.5 Elsewhere in the Iliad Homer attributes the rearing of Chimera to Amisodorus.6 Hesiods Theogony follows the Homeric description: he makes the Chimera the issue of Echidna: She was the mother of Chimaera who breathed raging fire a creature fearful great swift-footed and strong who had three heads one of a grim-eyed lion in her hinderpart a dragon and in her middle a goat breathing forth a fearful blast of blazing fire. Her did Pegasus and noble Bellerophon slay.7 The author of the Bibliotheca concurs:8 Descriptions agree that she breathed fire. The Chimera is generally considered to have been female see the quotation from Hesiod above despite the mane adorning her head the inclusion of a close mane was often depicted on lionesses but the ears were always visible that does not occur with depictions of male lions.", null, "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/chimera.jpg", null, "neutral", "Chimera", null, "Greek", "670bc", null, "Hybrid/Lion/Goat/Snake", "Hybrid/Lion/Goat/Snake", null },
                    { 23, "Earthquakes", "Bahamut Bahamoot Bahamūt from Hebrew Behemoth is a sea monster gigantic fish whale or sea serpent that lies deep below underpinning the support structure that holds up the earth according to Zakariya al-Qazwini. In this conception of the world the earth is shouldered by an angel who stands on a slab of gemstone which is supported by the cosmic beast ox sometimes called KuyuthaKuyuthanKiyubanKibuthan most likely from a corruption or misrendering of Hebrew Leviathan. The fishwhale Bahamut carries this bull on its back and is suspended in water for its own stability.", "Sea", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/bahamut.jpg", null, "neutral", "Bahamut", null, "Arabic", null, null, "Serpent", "Serpent", null },
                    { 2, "Combat/War", "Ancient Greek god of war.", "Celestial Spheres, Mount Olympus", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/ares.jpg", "Eternal", "Neutral", "Ares", null, "Ancient Greece", null, null, "Humanoid", "Deity", null },
                    { 3, "paralysis/death gaze/venom", "In European bestiaries and legends a basilisk is a legendary reptile reputed to be a serpent king who can cause death with a single glance. According to the Naturalis Historia of Pliny the Elder the basilisk of Cyrene is a small snake being not more than twelve fingers in length that is so venomous it leaves a wide trail of deadly venom in its wake and its gaze is likewise lethal. Its weakness is the odor of the weasel and the tears of a griffin which according to Pliny was thrown into the basilisks hole recognizable because some of the surrounding shrubs and grass had been scorched by its presence. It is possible that the legend of the basilisk and its association with the weasel in Europe was inspired by accounts of certain species of Asiatic snakes such as the king cobra and their natural predator the mongoose.", null, "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/basilisk.jpg", null, "evil", "Basilisk", null, "Greek", null, "cockatrice", "reptile", "snakelike", "weasel odor/griffin tears" },
                    { 4, "invisibility/teleportation/wish-granting", "The exact origins of belief in jinn are not entirely clear.19 Some scholars of the Middle East hold that they originated as malevolent spirits residing in deserts and unclean places who often took the forms of animals19 others hold that they were originally pagan nature deities who gradually became marginalized as other deities took greater importance.19 Still jinn had been worshipped by many Arabs during the Pre-Islamic period20 but unlike gods jinn were not regarded as immortal. But although their mortality ranks them lower than gods it seems veneration of jinn had played more importance in the everyday life of pre-Islamic Arabs than the gods themselves. According to common Arabian belief soothsayers pre-Islamic philosophers and poets were inspired by the jinn.2019 Their culture and society were analogous to that pre-Islamic Arabian culture with tribal leaders protected their allies and avenge murder for any member of their tribe or allies. Although the powers of jinn exceed those of humans it is conceivable a man could kill a jinni in single combat. Jinn were thought to shift into different shapes but were feared especially in their invisible form since when they could attack without being seen.21 Jinn were also feared because they had been thought to be responsible for various diseases and mental illnesses.2219 Julius Wellhausen observed that such spirits were thought to inhabit desolate dingy and dark places and that they were feared.23 One had to protect oneself from them but they were not the objects of a true cult.23 Some scholars argue that angels and demons were introduced by Muhammad to Arabia and did not exist among the jinn. On the other hand Amira El-Zein argues that angels were known to the pagan Arabs but the term jinn was used for all kinds of supernatural entities among various religions and cults thus Zoroastrian Christian and Jewish angels and demons were conflated with jinn.20 Al-Jahiz credits the pre-Islamic Arabs with believing that the society of jinn constitutes several tribes and groups and some natural events were attributed to them such as storms. They also thought jinn could protect marry kidnap possess and kill people.24", "desert", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/jinn.jpg", "sub-immortal", "neutral", "Jinn", null, "Arabic", null, "djinn/genie", "spirit", "spirit", null },
                    { 5, "flight", "According to Vidal a Spanish historian this creature was supposed to live near Céret in the County of Roussillon of modern-day France during the Middle Ages. Claw marks were found on a rock near Mas Carol.9 The belief in the existence of the hippogriff such as Ariosto describes is fiercely attacked in a scientific essay on religion in 1862 which argues that such an animal can neither be a divine creation nor truly exist. The Book of Enoch quite clearly details how Satan and his fallen angels created various hybrids by admixture. The Sphinx is the most well known such hybrid. The hippogriff is supposed to be a mixture of several animals and the author notes that in order to support its weight the wings would be so heavy that flight would be impossible which proves—without question—that it does not exist.10 In some traditions the hippogriff is said to be the symbol of love as its parents the mare and griffin are natural enemies.10 In other traditions the hippogriff represents Christs dual nature as both human and divine.11", null, null, null, null, "Hippogriff", null, "Greek", "1615", null, "eagle/horse", "eagle/horse", null },
                    { 6, "servantry", "Hobgoblins seem to be small hairy little men who like their close relatives the brownies are often found within human dwellings doing odd jobs around the house while the family is asleep. Such chores are typically small tasks like dusting and ironing. Often the only compensation necessary in return for these is food. While brownies are more peaceful creatures hobgoblins are more fond of practical jokes. They also seem to be able to shapeshift as seen in one of Pucks monologues in A Midsummer Nights Dream. Robin Goodfellow is perhaps the most mischievous and most infamous of all his kind but many are less antagonizing. Like other fae folk hobgoblins are easily annoyed. They can be mischievous frightening and even dangerous.4 Attempts to give them clothing will often banish them forever though whether they are offended by such gifts or are simply too proud to work in new clothes differs from teller to teller.", "home", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/hobgoblin.jpg", null, "good", "Hobgoblin", null, "English", "1530", null, "goblin", null, null },
                    { 7, "Double-regrowth/Venom", "The Lernaean Hydra or Hydra of Lerna Greek: Λερναῖα Ὕδρα Lernaîa Hýdra more often known simply as the Hydra is a serpentine water monster in Greek and Roman mythology. Its lair was the lake of Lerna in the Argolid which was also the site of the myth of the Danaïdes. Lerna was reputed to be an entrance to the Underworld1 and archaeology has established it as a sacred site older than Mycenaean Argos. In the canonical Hydra myth the monster is killed by Heracles Hercules as the second of his Twelve Labors.2 According to Hesiod the Hydra was the offspring of Typhon and Echidna.3 It had poisonous breath and blood so virulent that even its scent was deadly.4 The Hydra possessed many heads the exact number of which varies according to the source. Later versions of the Hydra story add a regeneration feature to the monster: for every head chopped off the Hydra would regrow two heads.5 Heracles required the assistance of his nephew Iolaus to cut off all of the monsters heads and burn the neck using a sword and fire.6", "swamp", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/hydra.jpg", null, "Evil", "Hydra", "Hercules", "Greek", "500bc", null, "Serpent", "Serpent", null },
                    { 8, "large size, strength", null, "Pacific Northwest", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/sasquatch.jpg", null, "good", "Sasquatch", null, "native american", "1830s", null, "bipedal ape-like", null, null },
                    { 9, "mischief", null, "the woods", null, null, "evil", "Satyr", null, "Greek", null, "human/nymph", "human-animal hybrids", null, null },
                    { 10, "paralyzing and possession", null, "everywhere", null, null, "unknown", "Shadow Person", null, null, null, null, "shade", "supernatural", null },
                    { 11, null, null, null, null, null, null, "Shug Monkey", null, null, null, null, "dog/monkey", null, null },
                    { 12, "causes memory loss, blind following", null, "Vyraj/ Euphrates River", null, null, "evil", "Sirin", null, "russian", null, null, "humanoid/bird", null, null },
                    { 13, "transformation", null, "us", null, null, "evil", "Skin-Walker", null, "Navajo", null, null, "humanoid/animal", "witch", null },
                    { 14, "Flys ", "Ancient Achaemenid Assyrian seals depict winged unicorns and winged bulls as representing evil but winged unicorns can also represent light.", "Ancient Mesopotamia", null, null, "Good/Evil", "Alicorn", null, "Achaemenid Assyria", "400 BCE", "Pegasus", "Animal", "Horse andBird and Rhino", null },
                    { 15, "Flight, combat", "Supernatural beings that act as agents envoys and messengers of God.", "Celestial spheres", null, "Eternal", "good", "Angel", "Lucifer/Satan", "Biblical Hebrew, Christian, Islamic", null, "Divine Thrones, Living Creatures, Seraphim, Cherubim", "Various", "Various", "Pride" },
                    { 16, "Beauty, seduction, war", "Ancient Greek goddess associated with beauty love passion pleasure and procreation.", "Celestial spheres, Mount Olympus", null, "Eternal", "Neutral", "Aphrodite", null, "Ancient Greece", null, null, "Humanoid", "Deity", null },
                    { 17, "Archery, Dance, Healing, Light, Music, Poetry, Prophecy", "Olympian deity in classical Greek and Roman mythology.", "Celestial Spheres, Mount Olympus", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/apollo.jpg", "Eternal", "Neutral", "Apollo", null, "Ancient Greece, Ancient Rome", "8th Century BC", null, "Humanoid", "Deity", null },
                    { 18, "Weaving", "Daughter of Idmon challenged Athena to a weaving contest and was was beaten by the latter with a weaving shuttle when she won hanged herself out of shame and was transformed into a spider.", "Lydia, Asia Minor", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/arachne.jpg", "Immortal", "Neutral", "Arachne", "Athena", "Ancient Rome", "1st Century BC", null, "Arachnid, Human", "Human/Spider", null },
                    { 19, "Hunting", "Goddess of chastity childbirth the hunt midwifery the Moon wild animals the wilderness.", "Mount Olympus, Celestial Spheres", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/artemis.jpg", "Eternal", "Neutral", "Artemis", null, "Ancient Greece", null, null, "Humanoid", "Deity", null },
                    { 20, "Deception, Sinking Ships", "Sea creature variously described as a large whale vast sea turtle or giant sea monster with huge spines on the ridge of its back often mistaken for an island and appearing to be rocky with crevices and valleys trees and greenery and having sand dunes all over it. It rises to the surface from the depths of the sea and entices unwitting sailors with its island appearance to make landfall on its huge shell and then the whale pulls them under the sea drowning and devouring them. It also emits a sweet smell that lures fish into its trap where it then devours them.", "Sea", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/aspidochelone.jpg", null, "Evil", "Aspidochelone", null, "Greco-Roman", "2nd Century AD", null, "Whale", "Sea Monster", null },
                    { 21, "Handicraft, Strategy, Warfare, Wisdom", "Goddess of handicraft strategic warfare and wisdom.", "Mount Olympus, Celestial Spheres", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/athena.jpg", "Eternal", "Good", "Athena", null, "Ancient Greece", "16th-12th Century BC", null, "Humanoid", "Deity", null },
                    { 22, "Flight, Assistance finding people, eating children", "Supernatural being who appears as a deformed or ferocious-looking old woman flying around in a mortar wielding a pestle dwelling deep in the forest in a hut that stands on chicken legs.", "Forest", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/baba-yaga.jpg", null, "Neutral", "Baba Yaga", null, "Tsarist Russia", "1755", null, "Humanoid", "Supernatural Being", null },
                    { 24, "none", "The most common theory holds that the idea of centaurs came from the first reaction of a non-riding culture as in the Minoan Aegean world to nomads who were mounted on horses. The theory suggests that such riders would appear as half-man half-animal. Bernal Díaz del Castillo reported that the Aztecs also had this misapprehension about Spanish cavalrymen.16 The Lapith tribe of Thessaly who were the kinsmen of the Centaurs in myth were described as the inventors of horse-riding by Greek writers. The Thessalian tribes also claimed their horse breeds were descended from the centaurs.Robert Graves relying on the work of Georges Dumezil17 who argued for tracing the centaurs back to the Indian Gandharva speculated that the centaurs were a dimly remembered pre-Hellenic fraternal earth cult who had the horse as a totem.18 A similar theory was incorporated into Mary Renaults The Bull from the Sea.", "Forest", "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/centaur.jpg", null, "neutral", "Centaur", null, "Greek", null, "human/horse", "Hybrid/Humanoid", "hybrid/horse/man", null },
                    { 49, "undead/creates other zombies", "A zombie Haitian French: zombi Haitian Creole: zonbi is a fictional undead corporeal revenant created through the reanimation of a corpse. Zombies are most commonly found in horror and fantasy genre works. The term comes from Haitian folklore in which a zombie is a dead body reanimated through various methods most commonly magic. Modern depictions of the reanimation of the dead do not necessarily involve magic but often invoke science fictional methods such as carriers radiation mental diseases vectors pathogens parasites scientific accidents etc.12", null, null, null, "evil", "Zombie", null, "Hatian", "1819", null, "undead", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 49);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 1,
                columns: new[] { "CreatureAbility", "CreatureDescription", "CreatureHabitat", "CreatureImage", "CreatureLifespan", "CreatureMorality", "CreatureName", "CreatureNemesis", "CreatureOriginCulture", "CreatureOriginDate", "CreatureRelatedCreature", "CreatureTaxonomy", "CreatureType", "CreatureWeakness" },
                values: new object[] { "Fire-Breathing", "this is my description of Matilda the fire-breathing kid", "Chokey", "http://wwww.dummyurl.com", "86", "good", "Matilda", "mom and dad", null, "1996", "None", "Human", "Little girl", "water" });
        }
    }
}
