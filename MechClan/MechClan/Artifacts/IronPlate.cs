using MechClan.Cards;
using MonsterTrainModdingAPI.Builders;
using System.Collections.Generic;
using static MonsterTrainModdingAPI.Constants.VanillaRelicPoolIDs;

namespace MechClan.Artifacts
{
    class IronPlate
    {
        public static string ID = "IronPlate";

        public static void Make()
        {
            var relic = new CollectableRelicDataBuilder
            {
                RelicPoolIDs = new List<string> { MegaRelicPool },
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                         RelicEffectClassName = typeof(RelicEffectModifyTriggerCount).AssemblyQualifiedName,
                         ParamSourceTeam = Team.Type.Heroes,
                         ParamInt = 1,
                         ParamTrigger = CharacterTriggerData.Trigger.PostCombat,
                         ParamTargetMode = TargetMode.Room,
                    }
                }
            };
            Utils.AddRelic(relic, ID);

            relic.BuildAndRegister();
        }
    }
}
