using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Upgrades
{
    class MechVanguardGuzzlerPremium
    {
        public static string IDName = "GuzzlerUpgradePremium";
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
                BonusDamage = 25,
                BonusHP = 30,
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

              
            };

            return railtie;
        }
        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}
