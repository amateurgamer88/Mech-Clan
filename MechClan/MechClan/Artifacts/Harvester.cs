using MechClan.Cards;
using MonsterTrainModdingAPI.Builders;
using System.Collections.Generic;
using static MonsterTrainModdingAPI.Constants.VanillaRelicPoolIDs;

namespace MechClan.Artifacts
{
    class Harvester
    {
        public static string ID = "Harvester";

        public static void Make()
        {
            var relic = new CollectableRelicDataBuilder
            {
                RelicPoolIDs = new List<string> { MegaRelicPool },
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                        RelicEffectClassName = typeof(RelicEffectChangeGoldReward).AssemblyQualifiedName,
                        ParamFloat = 0.75f,
                        ParamTargetMode = TargetMode.Room,
                    },

                    new RelicEffectDataBuilder
                    {
                        RelicEffectClassName = typeof(RelicEffectChangeStartingHandSize).AssemblyQualifiedName,
                        ParamInt = 1,
                        ParamTargetMode = TargetMode.Room,
                    }
                },

            };
            Utils.AddRelic(relic, ID);

            relic.BuildAndRegister();
        }
    }
}
