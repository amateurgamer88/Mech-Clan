using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.UncommonSpells
{
    class FlawedShield
    {
        public static string IDName = "FlawedShield";

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
                    TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "debuff", count=2} }
                    },

                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectAddStatusEffect",
                    ParamInt = 100,
                    TargetMode = TargetMode.DropTargetCharacter,
                    TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "armor", count=5} }

                    }
                },

            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "FlawedShield.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
