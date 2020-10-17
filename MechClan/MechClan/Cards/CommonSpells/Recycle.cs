using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.CommonSpells
{
    class Recycle
    {
        public static string IDName = "Recycle";

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
                        EffectStateName = "CardEffectSacrifice",
                        ParamInt = 100,
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes,
                    },

                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectAddStatusEffect",
                    ParamInt = 100,
                    TargetMode = TargetMode.FrontInRoom,
                    TargetTeamType = Team.Type.Heroes,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "spark", count=1} }
                    }
                },

            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "Recycle.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
