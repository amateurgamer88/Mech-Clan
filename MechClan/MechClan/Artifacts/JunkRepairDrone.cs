using MechClan.Cards;
using MonsterTrainModdingAPI.Builders;
using System.Collections.Generic;
using static MonsterTrainModdingAPI.Constants.VanillaRelicPoolIDs;

namespace MechClan.Artifacts
{
    class JunkRepairDrone
    {
        public static string ID = "JunkRepairDrone";

        public static void Make()
        {
            var relic = new CollectableRelicDataBuilder
            {
                RelicPoolIDs = new List<string> { MegaRelicPool },
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                        RelicEffectClassName = typeof(RelicEffectDamageOrHealUnitsEndOfTurn).AssemblyQualifiedName,
                        ParamInt = 3,
                        ParamSourceTeam = Team.Type.Heroes,
                        ParamBool = true,
                    }
                },

            };
            Utils.AddRelic(relic, ID);

            relic.BuildAndRegister();
        }
    }
}
