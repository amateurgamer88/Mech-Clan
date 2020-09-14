using MechClan.Cards;
using MonsterTrainModdingAPI.Builders;
using System.Collections.Generic;
using static MonsterTrainModdingAPI.Constants.VanillaRelicPoolIDs;

namespace MechClan.Artifacts
{
    class Recycler
    {
        public static string ID = "Recycler";

        public static void Make()
        {
            var relic = new CollectableRelicDataBuilder
            {
                RelicPoolIDs = new List<string> { MegaRelicPool },
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                        RelicEffectClassName = typeof(RelicEffectModifyTowerMaxHealth).AssemblyQualifiedName,
                        ParamInt = 2,
                        ParamTrigger = CharacterTriggerData.Trigger.OnAnyHeroDeathOnFloor,
                    }
                },

            };
            Utils.AddRelic(relic, ID);

            relic.BuildAndRegister();
        }
    }
}
