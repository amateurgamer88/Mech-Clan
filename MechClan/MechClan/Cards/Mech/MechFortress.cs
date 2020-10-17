using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechClan.Cards.Mech
{
    class MechFortress
    {
        public static string IDName = "MechFortress";
        public static string imgName = "MechFortress";
        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Cost = 7,
                Rarity = CollectableRarity.Rare,
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

                Size = 6,
                Health = 200,
                AttackDamage = 150,

                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                    Trigger = CharacterTriggerData.Trigger.OnHit,
                    EffectBuilders = new List<CardEffectDataBuilder>
                    {
                            new CardEffectDataBuilder
                            {
                                EffectStateName = "CardEffectAddStatusEffect",
                                TargetMode = TargetMode.Self,
                                ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "armor", count=5} }

                            }
                    }
                    },
                }
            };
            
            Utils.AddUnitImg(characterDataBuilder, imgName + ".png");
            return characterDataBuilder.BuildAndRegister();
        }
    }
}
