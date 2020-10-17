using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Upgrades
{
    class MechTowerMinelayerPremium
    {
        public static string IDName = "MinelayerUpgradePremium";
        public static int buffAmount = 2;

        public static CardUpgradeDataBuilder Builder()
        {
            CardUpgradeDataBuilder railtie = new CardUpgradeDataBuilder
            {
                UpgradeTitleKey = IDName + "_Name",
                UpgradeDescriptionKey = IDName + "_Desc",
                
                //HideUpgradeIconOnCard = false,
                UseUpgradeHighlightTextTags = true,
                //BonusDamage = 0,
                BonusHP = 40,
                //costReduction = 0,
                //xCostReduction = 0,
                //bonusHeal = 0,
                //BonusSize = 0,

                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {

                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnAnyUnitDeathOnFloor,
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectDamage",
                                TargetMode = TargetMode.Room,
                                TargetTeamType = Team.Type.Monsters,
                                ParamInt = 5,
                            },
                        },
                    }
                },
            };

            return railtie;
        }
        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}
