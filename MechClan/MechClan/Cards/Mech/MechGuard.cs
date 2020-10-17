using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechClan.Cards.Mech
{
    class MechGuard
    {
        public static string IDName = "MechGuard";
        public static string imgName = "MechGuard";
        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Cost = 2,
                Rarity = CollectableRarity.Uncommon,
            };

            Utils.AddUnit(railyard, IDName, BuildUnit());
            Utils.AddImg(railyard, imgName + ".png");

            // Do this to complete
            railyard.BuildAndRegister();
        }

        // Builds the unit
        public static CharacterData BuildUnit()
        {
            // Monster card, so we build an attached unit
            CharacterDataBuilder characterDataBuilder = new CharacterDataBuilder
            {
                CharacterID = IDName,
                NameKey = IDName + "_Name",
                SubtypeKeys = new List<string> { "AGSubtype_Mech" },

                Size = 2,
                Health = 10,
                AttackDamage = 0,

                StartingStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { count = 25, statusId = "armor" } },

                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnSpawn,
                        DisplayEffectHintText = true,
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectAddStatusEffect",
                                TargetMode = TargetMode.FrontInRoom,
                                TargetTeamType = Team.Type.Heroes,
                                ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "armor", count=20} }
                            },
                        }
                    }
                },
            };

            Utils.AddUnitImg(characterDataBuilder, imgName + ".png");
            return characterDataBuilder.BuildAndRegister();
        }
    }
}
