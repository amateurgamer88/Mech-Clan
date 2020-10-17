using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.RareSpells
{
    class OrbitalBombardment
    {
        public static string IDName = "OrbitalBombardment";

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
                    TargetTeamType = Team.Type.Monsters,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "debuff", count=1} }
                    },

                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectDamage",
                        ParamInt = 25,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Monsters,
                    },

                },



            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "OrbitalBombardment.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
