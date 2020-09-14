using MechClan.Cards;
using MonsterTrainModdingAPI.Builders;
using System.Collections.Generic;
using static MonsterTrainModdingAPI.Constants.VanillaRelicPoolIDs;

namespace MechClan.Artifacts
{
    class VanguardsEmblem
    {
        public static string ID = "VanguardsEmblem";

        public static void Make()
        {
            var relic = new CollectableRelicDataBuilder
            {
                RelicPoolIDs = new List<string> { MegaRelicPool },
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                        RelicEffectClassName = typeof(RelicEffectModifyRandomRoomCapacity).AssemblyQualifiedName,
                        ParamInt = 2,
                        ParamTargetMode = TargetMode.Room,
                    },

                       
                }
            };
            Utils.AddRelic(relic, ID);

            relic.BuildAndRegister();
        }
    }
}
