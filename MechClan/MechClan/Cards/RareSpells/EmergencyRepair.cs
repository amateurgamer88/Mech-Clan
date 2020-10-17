using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.RareSpells
{
    class EmergencyRepair
    {
        public static string IDName = "EmergencyRepair";

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
                    TargetMode = TargetMode.Room,
                    TargetTeamType = Team.Type.Heroes,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "armor", count=20} }
                    },

                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectHeal",
                    ParamInt = 9999,
                    ParamMultiplier = 1, 
                    TargetMode = TargetMode.Room,
                    TargetTeamType = Team.Type.Heroes,
                    },

                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectAddStatusEffect",
                    ParamInt = 100,
                    TargetMode = TargetMode.Room,
                    TargetTeamType = Team.Type.Heroes,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "scorch", count=1} }
                    }
                },



            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "EmergencyRepair.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
