using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MechClan_1.Cards.Mech
{
    class MechRefiner
    {
        //unique ID (GUID can make this unique from other same name cards)
        /*public static string ID = AGMech.GUID + "MechRefiner";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                //Card ID
                CardID = MechRefiner.ID,

                //Description of what this card does 
                Description = "<b>Resolve:</b> Apply [spark] <b>1</b> to front friendly unit.",
                //Ember cost of this card
                Cost = 1,
                //rarity of this card (Starter, Common, Uncommon and Rare)
                Rarity = CollectableRarity.Uncommon,
                //Pick the clan for this card (clanless for this card)
                ClanID = VanillaClanIDs.Clanless,
                //path to the picture for this card
                AssetPath = "assets/amateur.png",
                //card pool this card belongs to
                CardPoolIDs = new List<string> { "Awoken", UnitsAllBanner },

                CardType = CardType.Monster,
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                    EffectStateType = typeof(CardEffectSpawnHero),
                    TargetMode = TargetMode.DropTargetCharacter,
                    ParamCharacterDataBuilder = new CharacterDataBuilder
                    {
                        CharacterID = MechRefiner.ID,
                        Name = "Mech Refiner",
                        Size = 1,
                        Health = 1,
                        AttackDamage = 0,
                        AssetPath = "assets/amateur.png",
                        SubtypeKeys = new List<string> { "MechSubtype_Mech" },

                        TriggerBuilders = new List<CharacterTriggerDataBuilder>
                        {
                            new CharacterTriggerDataBuilder
                            {
                               Trigger = CharacterTriggerData.Trigger.PostCombat,
                               EffectBuilders = new List<CardEffectDataBuilder>
                               {
                                    new CardEffectDataBuilder
                                    {
                                        EffectStateType = typeof(CardEffectAddStatusEffect),
                                        TargetMode = TargetMode.FrontInRoom,
                                        TargetTeamType = Team.Type.Heroes,
                                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "Spark", count=1} }
                                    },
                               }
                            },
                        },
                    }
                    }
                },
            };

            //Do this to complete the card building
            railyard.BuildAndRegister();
        }*/
    }
}
