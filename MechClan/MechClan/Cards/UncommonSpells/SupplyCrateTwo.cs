using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.UncommonSpells
{
    class SupplyCrateTwo
    {
        public static string IDName = "SupplyCrateTwo";

        public static void Make()
        {

            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Cost = 2,
                Rarity = CollectableRarity.Uncommon,

                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        ParamInt = 100,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Heroes,
                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "armor", count=15} }
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
            Utils.AddImg(railyard, "SupplyCrateTwo.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
