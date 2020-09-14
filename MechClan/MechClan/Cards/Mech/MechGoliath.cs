﻿using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.Mech
{
    class MechGoliath
    {
        public static string IDName = "MechGoliath";
        public static string imgName = "MechGoliath";
        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Cost = 4,
                Rarity = CollectableRarity.Rare,
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

                Size = 4,
                Health = 25,
                AttackDamage = 30,

                StartingStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { count = 1, statusId = "inert" } },

                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {

                    new CharacterTriggerDataBuilder
                    {
                    Trigger = CharacterTriggerData.Trigger.OnKill,
                    EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardTriggerEffectBuffCharacterDamage",
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
