using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Upgrades
{
    class MechTowerSwarmerPro
    {
        public static string IDName = "SwarmerUpgradePro";
        public static int buffAmount = 3;

        public static CardUpgradeDataBuilder Builder()
        {
            CardUpgradeDataBuilder railtie = new CardUpgradeDataBuilder
            {
                UpgradeTitleKey = IDName + "_Name",
                UpgradeDescriptionKey = IDName + "_Desc",
                
                //HideUpgradeIconOnCard = false,
                UseUpgradeHighlightTextTags = true,
                //BonusDamage = 0,
                //BonusHP = 0,
                //costReduction = 0,
                //xCostReduction = 0,
                //bonusHeal = 0,
                //BonusSize = 0,

                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {

                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.CardMonsterPlayed,
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectAddTempCardUpgradeToUnits",
                                TargetMode = TargetMode.Self,
                                ParamCardUpgradeData = new CardUpgradeDataBuilder
                                {
                                    BonusDamage = 20,
                                    BonusHP = 20,
                                    HideUpgradeIconOnCard = true,
                                }.Build(),
                            }
                        },
                    },

                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnSpawn,
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectAdjustRoomCapacity",
                                TargetCardType = CardType.Monster,
                                TargetCardSelectionMode = CardEffectData.CardSelectionMode.RandomToHand,
                                ParamInt = 2,
                            }
                        },
                    },
                },
            };

            return railtie;
        }
        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}
