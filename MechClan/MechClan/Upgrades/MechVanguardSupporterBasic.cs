using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Upgrades
{
    class MechVanguardSupporterBasic
    {
        public static string IDName = "SupporterUpgradeBasic";
        public static int buffAmount = 1;
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
                BonusHP = 5,
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
                                EffectStateName = "CardEffectSpawnMonster",
                                TargetMode = TargetMode.FrontInRoom,
                                TargetTeamType = Team.Type.Heroes,
                                ParamInt = 2,
                                AdditionalParamInt = 2,
                                ParamCharacterData = BuildFillerUnit(),
                            }
                        }
                    }
                },

            };

            return railtie;
        }

        public static CharacterData BuildFillerUnit()
        {
            // Monster card, so we build an attached unit
            CharacterDataBuilder characterDataBuilder = new CharacterDataBuilder
            {
                CharacterID = "MechToken",
                NameKey = "MechToken" + "_Name",

                Size = 1,
                Health = 1,
                AttackDamage = 0,
                CanAttack = false,
                PriorityDraw = false,
                CanBeHealed = false,
            };

            characterDataBuilder.SubtypeKeys = new List<string> { "MechSubtype_Token" };
            return characterDataBuilder.BuildAndRegister();

        }



        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}
