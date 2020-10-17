using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.CommonSpells
{
    class ScrapHeap
    {
        public static string IDName = "ScrapHeap";

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
                    EffectStateName = "CardEffectAddStatusEffect",
                    ParamInt = 100,
                    TargetMode = TargetMode.Room,
                    TargetTeamType = Team.Type.Heroes,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "armor", count=3} }
                    }
                },

            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "Replicate.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
