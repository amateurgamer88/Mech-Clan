using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards.UncommonSpells
{ 
    class OilDrench
    {
        public static string IDName = "OilDrench";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Cost = 1,
                Rarity = CollectableRarity.Uncommon,

                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                    EffectStateName = "CardEffectAddStatusEffect",
                    ParamInt = 100,
                    TargetMode = TargetMode.Room,
                    TargetTeamType = Team.Type.Monsters,
                    ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "debuff", count=1} }
                    }
                },

            };

            Utils.AddSpell(railyard, IDName);
            Utils.AddImg(railyard, "OilDrench.png");

            // Do this to complete
            railyard.BuildAndRegister();
        }
    }
}
