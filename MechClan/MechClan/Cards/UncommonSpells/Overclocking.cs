using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.UncommonSpells
{
    class Overclocking
    {
        public static string IDName = "Overclocking";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Cost = 0,
                Rarity = CollectableRarity.Uncommon,

                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectAddStatusEffect",
                    ParamInt = 100,
                    TargetMode = TargetMode.DropTargetCharacter,
                    TargetTeamType = Team.Type.Heroes,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "Spark", count=-1} }
                    },

                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectAddTempCardUpgradeToUnits",
                    ParamInt = 100,
                    TargetMode = TargetMode.DropTargetCharacter,
                    TargetTeamType = Team.Type.Heroes,
                    ParamCardUpgradeData = new CardUpgradeDataBuilder
                    {
                        BonusDamage = 5,
                        BonusHP = -2,
                        HideUpgradeIconOnCard = true,
                    }.Build(),
                    },

                },
            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "Overclocking.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
