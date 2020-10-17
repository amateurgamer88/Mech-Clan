using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MechClan_1.Cards.Mech
{
    class MechEnforcer
    {
        //unique ID (GUID can make this unique from other same name cards)
        /*public static string ID = AGMech.GUID + "MechEnforcer";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                //Card ID
                CardID = MechEnforcer.ID,

                //Description of what this card does (effect0.power references a value so you don't have to description all the time)
                Description = "<b>Harvest</b>: Apply +5 [attack].",
                //Ember cost of this card
                Cost = 2,
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
                        CharacterID = MechEnforcer.ID,
                        Name = "Mech Enforcer",
                        Size = 3,
                        Health = 15,
                        AttackDamage = 20,
                        AssetPath = "assets/amateur.png",
                        SubtypeKeys = new List<string> { "MechSubtype_Mech" },

                        StartingStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { count = 10, statusId = "armor" }, new StatusEffectStackData { count = 1, statusId = "inert" } },

                        TriggerBuilders = new List<CharacterTriggerDataBuilder>
                        {

                            new CharacterTriggerDataBuilder
                            {
                            Trigger = CharacterTriggerData.Trigger.OnAnyUnitDeathOnFloor,
                            EffectBuilders = new List<CardEffectDataBuilder>
                                {
                                    new CardEffectDataBuilder
                                    {
                                        EffectStateType = typeof(CardEffectAddTempCardUpgradeToUnits),
                                        TargetMode = TargetMode.Self,

                                         ParamCardUpgradeData = new CardUpgradeDataBuilder
                                        {
                                            BonusDamage = 5,
                                            HideUpgradeIconOnCard = true,
                                        }.Build(),
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


        }*/
        
    }
}
