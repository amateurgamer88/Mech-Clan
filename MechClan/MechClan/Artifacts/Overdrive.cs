using MechClan.Cards;
using MonsterTrainModdingAPI.Builders;
using System.Collections.Generic;
using static MonsterTrainModdingAPI.Constants.VanillaRelicPoolIDs;

namespace MechClan.Artifacts
{
    class Overdrive
    {
        public static string ID = "Overdrive";

        public static void Make()
        {
            var relic = new CollectableRelicDataBuilder
            {
                RelicPoolIDs = new List<string> { MegaRelicPool },
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                        RelicEffectClassName = typeof(RelicEffectModifyCharacterAttackDamage).AssemblyQualifiedName,
                        ParamInt = 4,
                        ParamSourceTeam = Team.Type.Heroes,
                        ParamTrigger = CharacterTriggerData.Trigger.OnSpawn,
                        ParamTargetMode = TargetMode.Room,
                    }
                },

            };
            Utils.AddRelic(relic, ID);

            relic.BuildAndRegister();
        }
    }
}
