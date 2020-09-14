using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.RareSpells
{
    class Upgrade
    {
        public static string IDName = "Upgrade";

        public static void Make()
        {

            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Cost = 3,
                Rarity = CollectableRarity.Rare,

                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectAddStatusEffect",
                    ParamInt = 100,
                    TargetMode = TargetMode.DropTargetCharacter,
                    TargetTeamType = Team.Type.Heroes,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "Spark", count=2} }
                    },

                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddTempCardUpgradeToUnits",
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes,
                        ParamCardUpgradeData = new CardUpgradeDataBuilder
                        {
                            BonusDamage = 10,
                            HideUpgradeIconOnCard = true,
                        }.Build(),
                    },
                }

            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "Upgrade.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
