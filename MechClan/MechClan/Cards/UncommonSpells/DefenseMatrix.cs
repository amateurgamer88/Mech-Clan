using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.UncommonSpells
{
    class DefenseMatrix
    {
        public static string IDName = "DefenseMatrix";

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
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "damage shield", count=1} }
                    },

                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectAddStatusEffect",
                    ParamInt = 100,
                    TargetMode = TargetMode.DropTargetCharacter,
                    TargetTeamType = Team.Type.Heroes,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "armor", count=5} }
                    },

                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectAddStatusEffect",
                    ParamInt = 100,
                    TargetMode = TargetMode.DropTargetCharacter,
                    TargetTeamType = Team.Type.Heroes,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "scorch", count=1} }
                    }
                },

            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "DefenseMatrix.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
