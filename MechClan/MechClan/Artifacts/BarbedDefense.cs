using MechClan.Cards;
using MonsterTrainModdingAPI.Builders;
using System.Collections.Generic;
using static MonsterTrainModdingAPI.Constants.VanillaRelicPoolIDs;

namespace MechClan.Artifacts
{
    class BarbedDefense
    {
        public static string ID = "BarbedDefense";

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
                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId = "spikes", count = 1 } },

                    }
                },

            };
            Utils.AddRelic(relic, ID);

            relic.BuildAndRegister();
        }
    }
}
