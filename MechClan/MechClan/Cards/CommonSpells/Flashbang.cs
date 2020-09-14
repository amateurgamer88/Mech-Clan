using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.CommonSpells
{
    class Flashbang
    {
        public static string IDName = "Flashbang";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Cost = 1,
                Rarity = CollectableRarity.Common,

                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectRemoveAllStatusEffects",
                        ParamInt = 1,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Monsters,
                    },

                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        ParamInt = 100,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Monsters,
                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "Debuff", count=1} }

                    }
                },

            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "Flashbang.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
