using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MechClan_1.Cards.Mech
{
    class MechTitan
    {
        //unique ID (GUID can make this unique from other same name cards)
        public static string ID = AGMech.GUID + "MechTitans";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Name = "Mech Titan",
                //Card ID
                CardID = MechTitan.ID,

                //Description of what this card does 
                Description = "<b>Resolve:</b> Deal 10 damage to enemy units.",
                //Ember cost of this card
                Cost = 4,
                //rarity of this card (Starter, Common, Uncommon and Rare)
                Rarity = CollectableRarity.Rare,
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
                    EffectStateType = typeof(CardEffectSpawnMonster),
                    TargetMode = TargetMode.DropTargetCharacter,
                    ParamCharacterDataBuilder = new CharacterDataBuilder
                    {
                        CharacterID = MechTitan.ID,
                        Name = "Mech Titan",
                        Size = 3,
                        Health = 100,
                        AttackDamage = 50,
                        AssetPath = "assets/amateur.png",
                        SubtypeKeys = new List<string> { "MechSubtype_Mech" },

                        StartingStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { count = 25, statusId = "armor" }, new StatusEffectStackData { count = 1, statusId = "inert" } },

                        TriggerBuilders = new List<CharacterTriggerDataBuilder>
                        {
                            new CharacterTriggerDataBuilder
                            {
                                Trigger = CharacterTriggerData.Trigger.PostCombat,
                                DisplayEffectHintText = true,
                                EffectBuilders = new List<CardEffectDataBuilder>
                                {
                                    new CardEffectDataBuilder
                                    {
                                        EffectStateName = "CardEffectDamage",
                                        TargetMode = TargetMode.Room,
                                        TargetTeamType = Team.Type.Monsters,
                                        ParamInt = 10,
                                    },
                                }
                            }
                        }
                    }
                    }
                },
            };

            //Do this to complete the card building
            railyard.BuildAndRegister();


        }
    }
}
