using MechClan.Cards;
using MonsterTrainModdingAPI.Builders;
using System.Collections.Generic;
using static MonsterTrainModdingAPI.Constants.VanillaRelicPoolIDs;

namespace MechClan.Artifacts
{
    class ImprovedEngine
    {
        public static string ID = "ImprovedEngine";

        public static void Make()
        {
            var relic = new CollectableRelicDataBuilder
            {
                RelicPoolIDs = new List<string> { MegaRelicPool },
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                        RelicEffectClassName = typeof(RelicEffectAddStatusEffectOnStatusApplied).AssemblyQualifiedName,
                        ParamSourceTeam = Team.Type.Heroes,
                        ParamInt = 100,
                        ParamTargetMode = TargetMode.Room,
                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId = "Spark", count = 1 } },

                    }
                }
            };
            Utils.AddRelic(relic, ID);

            relic.BuildAndRegister();
        }
    }
}
