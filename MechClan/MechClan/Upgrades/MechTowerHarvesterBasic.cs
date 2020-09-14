using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Upgrades
{
    class MechTowerHarvesterBasic
    {
        public static string IDName = "HarvesterUpgradeBasic";
        public static int buffAmount = 1;

        public static CardUpgradeDataBuilder Builder()
        {
            CardUpgradeDataBuilder railtie = new CardUpgradeDataBuilder
            {
                UpgradeTitleKey = IDName + "_Name",
                UpgradeDescriptionKey = IDName + "_Desc",
                //upgradeIcon = CustomAssetManager.LoadSpriteFromPath("chrono/Clan Assets/clan_32.png"),
                //HideUpgradeIconOnCard = false,
                UseUpgradeHighlightTextTags = true,
                BonusDamage = 20,
                //BonusHP = 0,
                //costReduction = 0,
                //xCostReduction = 0,
                //bonusHeal = 0,
                //BonusSize = 0,

                StatusEffectUpgrades = new List<StatusEffectStackData> { new StatusEffectStackData { count = 1, statusId = "untouchable" }},

                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {

                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnAnyUnitDeathOnFloor,
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectAddStatusEffect",
                                TargetMode = TargetMode.Self,
                                TargetTeamType = Team.Type.Heroes,
                                ParamInt = 100,
                                ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "stygian_blessing", count=1} }
                            },

                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectRemoveStatusEffectOnStatusThreshold",
                                TargetMode = TargetMode.Self,
                                TargetTeamType = Team.Type.Heroes,
                                ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "stygian_blessing", count=4}, new StatusEffectStackData { statusId = "untouchable", count = 1 } }
                            },

                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectAddTempCardUpgradeToUnits",
                                TargetMode = TargetMode.Self,
                                TargetTeamType = Team.Type.Heroes,
                                ParamCardUpgradeData = new CardUpgradeDataBuilder
                                {
                                    BonusDamage = 2,
                                    BonusHP = 2,
                                    HideUpgradeIconOnCard = true,
                                }.Build(),
                            }
                        },
                    }
                },
            };

            return railtie;
        }
        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}
