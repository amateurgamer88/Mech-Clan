using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MechClan_1.Cards.Mech
{
    class Scavenger
    {
        //unique ID (GUID can make this unique from other same name cards)
        public static string ID = AGMech.GUID + "Scavenger";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                Name = "Scavenger",
                //Card ID
                CardID = Scavenger.ID,

                //Description of what this card does 
                Description = "<b>Harvest:</b> Gain [armor] <b>5</b>",
                //Ember cost of this card
                Cost = 1,
                //rarity of this card (Starter, Common, Uncommon and Rare)
                Rarity = CollectableRarity.Common,
                //Pick the clan for this card (clanless for this card)
                ClanID = VanillaClanIDs.Clanless,
                //path to the picture for this card
                AssetPath = "assets/amateur.png",
                //card pool this card belongs to
                CardPoolIDs = new List<string> { "Clanless", UnitsAllBanner },

                CardType = CardType.Monster,
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                    EffectStateType = typeof(CardEffectSpawnMonster),
                    TargetMode = TargetMode.DropTargetCharacter,
                    ParamCharacterDataBuilder = new CharacterDataBuilder
                    {
                        CharacterID = Scavenger.ID,
                        Name = "Scavenger",
                        Size = 2,
                        Health = 5,
                        AttackDamage = 0,
                        AssetPath = "assets/amateur.png",
                        SubtypeKeys = new List<string> { "MechSubtype_Mech" },

                        TriggerBuilders = new List<CharacterTriggerDataBuilder>
                        {
                            new CharacterTriggerDataBuilder
                            {
                                Trigger = CharacterTriggerData.Trigger.OnAnyUnitDeathOnFloor,
                                EffectBuilders = new List<CardEffectDataBuilder>
                                {
                                    new CardEffectDataBuilder
                                    {
                                        EffectStateName = "CardEffectAddStatusEffect",
                                        TargetMode = TargetMode.Self,
                                        ParamInt = 100,
                                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "armor", count=5} }
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


        }
    }
}
