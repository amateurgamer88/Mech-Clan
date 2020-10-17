using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using System;
using System.Collections.Generic;
using System.Text;


namespace MechClan.Cards.RareSpells
{
    class SupplyCrateFour
    {
        public static string IDName = "SupplyCrateFour";

        public static void Make()
        {

            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Cost = 2,
                Rarity = CollectableRarity.Rare,

                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        ParamInt = 100,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Heroes,
                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "Spark", count=2},  new StatusEffectStackData { statusId= "armor", count=15} },
                    },

                },

                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                         TraitStateName = "CardTraitExhaustState",
                    },
                }

            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "SupplyCrateFour.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
