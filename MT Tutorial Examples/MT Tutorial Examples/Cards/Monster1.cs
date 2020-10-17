using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MT_Tutorial_Examples.Cards
{
    class Monster1
    {
        //unique ID (GUID can make this unique from other same name cards)
        public static string ID = TestPlugin.GUID + "Monster_1";
        
        

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                //Card ID
                CardID = Monster1.ID,

                
                //Description of what this card does (effect0.power references a value so you don't have to description all the time)
                Description = "Tutorial Monster, roar!",
                //Ember cost of this card
                Cost = 1,
                //rarity of this card (Starter, Common, Uncommon and Rare)
                Rarity = CollectableRarity.Common,
                //Pick the clan for this card (clanless for this card)
                ClanID = VanillaClanIDs.Clanless,
                //path to the picture for this card
                AssetPath = "assets/amateur.png",
                //card pool this card belongs to
                CardPoolIDs = new List<string> { "Awoken", UnitsAllBanner },

                CardType = CardType.Monster,
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectSpawnMonster",
                    TargetMode = TargetMode.DropTargetCharacter,
                    ParamCharacterDataBuilder = new CharacterDataBuilder
                    {
                        CharacterID = Monster1.ID,
                        Name = "Tutorial Monster",
                        Size = 3,
                        Health = 10,
                        AttackDamage = 30,
                        AssetPath = "assets/amateur.png",
                        SubtypeKeys = new List<string> { "MechSubtype_Mine" },
                    }
                }
            }
            };

            //Do this to complete the card building
            railyard.BuildAndRegister();

        }
        
    }
}
