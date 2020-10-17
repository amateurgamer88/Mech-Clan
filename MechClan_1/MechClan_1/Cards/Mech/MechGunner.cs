using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MechClan_1.Cards.Mech
{
    class MechGunner
    {
        //unique ID (GUID can make this unique from other same name cards)
        /*public static string ID = AGMech.GUID + "MechGunner";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                //Card ID
                CardID = MechGunner.ID,

                //Description of what this card does 
                Description = "",
                //Ember cost of this card
                Cost = 1,
                //rarity of this card (Starter, Common, Uncommon and Rare)
                Rarity = CollectableRarity.Uncommon,
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
                    EffectStateType = typeof(CardEffectSpawnHero),
                    TargetMode = TargetMode.DropTargetCharacter,
                    ParamCharacterDataBuilder = new CharacterDataBuilder
                    {
                        CharacterID = MechGunner.ID,
                        Name = "Mech Gunner",
                        Size = 2,
                        Health = 15,
                        AttackDamage = 10,
                        AssetPath = "assets/amateur.png",
                        SubtypeKeys = new List<string> { "MechSubtype_Mech" },

                        StartingStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { count = 1, statusId = "inert" }, new StatusEffectStackData { count = 1, statusId = "hunter" } },

                    }
                    }
                },
            };

            //Do this to complete the card building
            railyard.BuildAndRegister();

        
        }*/
    }
}
