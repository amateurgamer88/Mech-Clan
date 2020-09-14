using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Upgrades
{
    class MechVanguardSupporterPro
    {
        public static string IDName = "SupporterUpgradePro";
        public static int buffAmount = 3;
        public static CardUpgradeDataBuilder Builder()
        {
            CardUpgradeDataBuilder railtie = new CardUpgradeDataBuilder
            {
                UpgradeTitleKey = IDName + "_Name",
                UpgradeDescriptionKey = IDName + "_Desc",
                //upgradeNotificationKey = IDName + "_Notice",
                //upgradeIcon = CustomAssetManager.LoadSpriteFromPath("chrono/Clan Assets/clan_32.png"),
                //HideUpgradeIconOnCard = false,
                UseUpgradeHighlightTextTags = true,
                BonusDamage = 0,
                BonusHP = 15,
                //costReduction = 0,
                //xCostReduction = 0,
                //bonusHeal = 0,
                //BonusSize = 0,

                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {
                        new CharacterTriggerDataBuilder
                        {
                                Trigger = CharacterTriggerData.Trigger.PostCombat,
                                EffectBuilders = new List<CardEffectDataBuilder>
                                {
                                        new CardEffectDataBuilder
                                        {
                                            EffectStateName = "CardEffectAddStatusEffect",
                                            TargetMode = TargetMode.Self,
                                            ParamInt = 100,
                                            ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "Armor", count=15} }
                                        },
                                }
                        },


                }
            };

            return railtie;
        }
        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}
