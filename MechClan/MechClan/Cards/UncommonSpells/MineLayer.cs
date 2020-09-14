using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.UncommonSpells
{
    class MineLayer
    {
        public static string IDName = "MineLayer";

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
                        EffectStateName = "CardEffectDamage",
                        ParamInt = 20,
                        TargetMode = TargetMode.FrontInRoom,
                        TargetTeamType = Team.Type.Monsters,
                    },

                },

                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateName = "CardTraitStrongerMagicPower",
                        ParamInt = 5,
                        ParamUseScalingParams = false,
                    }
                }

            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "MineLayer.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
