using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.Mech
{
    class MechEnforcer
    {
        public static string IDName = "MechEnforcer";
        public static string imgName = "MechEnforcer";
        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Cost = 2,
                Rarity = CollectableRarity.Uncommon,
            };

            Utils.AddUnit(railyard, IDName, BuildUnit());
            Utils.AddImg(railyard, imgName + ".png");

            // Do this to complete
            railyard.BuildAndRegister();
        }

        // Builds the unit
        public static CharacterData BuildUnit()
        {
            // Monster card, so we build an attached unit
            CharacterDataBuilder characterDataBuilder = new CharacterDataBuilder
            {
                CharacterID = IDName,
                NameKey = IDName + "_Name",
                SubtypeKeys = new List<string> { "AGSubtype_Mech" },

                Size = 3,
                Health = 15,
                AttackDamage = 20,

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
                                EffectStateName = "CardEffectAddTempCardUpgradeToUnits",
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
            };

            Utils.AddUnitImg(characterDataBuilder, imgName + ".png");
            return characterDataBuilder.BuildAndRegister();
        }
    }
}
