using MechClan.Cards;
using MonsterTrainModdingAPI.Builders;
using System.Collections.Generic;
using static MonsterTrainModdingAPI.Constants.VanillaRelicPoolIDs;

namespace MechClan.Artifacts
{
    class MiniFactory
    {
        public static string ID = "MiniFactory";

        public static void Make()
        {
            var relic = new CollectableRelicDataBuilder
            {
                RelicPoolIDs = new List<string> { MegaRelicPool },
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                        RelicEffectClassName = typeof(RelicEffectAddStatusEffectOnSpawn).AssemblyQualifiedName,
                        ParamSourceTeam = Team.Type.Heroes,
                        ParamTrigger = CharacterTriggerData.Trigger.OnSpawn,
                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId = "armor", count = 15 } },
                    },
                    new RelicEffectDataBuilder
                    {
                        RelicEffectClassName = typeof(RelicEffectModifyEnergy).AssemblyQualifiedName,
                        ParamInt = -1,
                        ParamTargetMode = TargetMode.Room,
                    }
                }
            };
            Utils.AddRelic(relic, ID);

            relic.BuildAndRegister();
        }
    }
}
