using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Upgrades
{
    class MechVanguardSupporterPremium
    {
        public static string IDName = "SupporterUpgradePremium";
        public static int buffAmount = 2;
        public static CardUpgradeDataBuilder Builder()
        {
            CardUpgradeDataBuilder railtie = new CardUpgradeDataBuilder
            {
                UpgradeTitleKey = IDName + "_Name",
                UpgradeDescriptionKey = IDName + "_Desc",
                //upgradeNotificationKey = IDName + "_Notice",
                
                //HideUpgradeIconOnCard = false,
                UseUpgradeHighlightTextTags = true,
                BonusDamage = 0,
                BonusHP = 10,
                //costReduction = 0,
                //xCostReduction = 0,
                //bonusHeal = 0,
                //BonusSize = 0,

                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {

                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.PostCombat,
                        DescriptionKey = IDName + "_Desc",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectAddStatusEffect",
                                TargetMode = TargetMode.FrontInRoom,
                                TargetTeamType = Team.Type.Heroes,
                                ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "Spark", count=2} }
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
