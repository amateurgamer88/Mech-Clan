﻿using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Upgrades
{
    class MechVanguardGuzzlerPro
    {
        public static string IDName = "GuzzlerUpgradePro";
        public static int buffAmount = 3;
        public static CardUpgradeDataBuilder Builder()
        {
            CardUpgradeDataBuilder railtie = new CardUpgradeDataBuilder
            {
                UpgradeTitleKey = IDName + "_Name",
                UpgradeDescriptionKey = IDName + "_Desc",
                //upgradeNotificationKey = IDName + "_Notice",
                
                //HideUpgradeIconOnCard = false,
                UseUpgradeHighlightTextTags = true,
                BonusDamage = 30,
                BonusHP = 40,
                //costReduction = 0,
                //xCostReduction = 0,
                //bonusHeal = 0,
                //BonusSize = 0,

                StatusEffectUpgrades = new List<StatusEffectStackData> {
                    new StatusEffectStackData
                    {
                        statusId = "multistrike",
                        count = 1,
                    },
                new StatusEffectStackData
                    {
                        statusId = "inert",
                        count = 1,
                    },
                },


                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {

                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnKill,
                        DescriptionKey = IDName + "_Desc",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectAddStatusEffect",
                                TargetMode = TargetMode.Self,
                                TargetTeamType = Team.Type.Heroes,
                                ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "buff", count=8} }
                            },

                        }

                    },
                },

            };

            return railtie;
        }
        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}
