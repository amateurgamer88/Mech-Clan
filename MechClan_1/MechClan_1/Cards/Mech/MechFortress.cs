using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MechClan_1.Cards.Mech
{
    class MechFortress
    {
        //unique ID (GUID can make this unique from other same name cards)
        /*public static string ID = AGMech.GUID + "MechFortress";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                //Card ID
                CardID = MechFortress.ID,

                //Description of what this card does 
                Description = "<b>Revenge:</b> Gain [armor] <b>5</b>.",
                //Ember cost of this card
                Cost = 7,
                //rarity of this card (Starter, Common, Uncommon and Rare)
                Rarity = CollectableRarity.Rare,
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
                        CharacterID = MechFortress.ID,
                        Name = "Mech Fortress",
                        Size = 6,
                        Health = 200,
                        AttackDamage = 150,
                        AssetPath = "assets/amateur.png",
                        SubtypeKeys = new List<string> { "MechSubtype_Mech" },

                        TriggerBuilders = new List<CharacterTriggerDataBuilder>
                        {
                            new CharacterTriggerDataBuilder
                            {
                            Trigger = CharacterTriggerData.Trigger.OnHit,
                            EffectBuilders = new List<CardEffectDataBuilder>
                            {
                                    new CardEffectDataBuilder
                                    {
                                        EffectStateType = typeof(CardEffectAddStatusEffect),
                                        TargetMode = TargetMode.Self,
                                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "armor", count=5} }

                                    }
                            }
                            },
                        }
                    }
                    }
                },
            };

            //Do this to complete the card building
            railyard.BuildAndRegister();


        }*/
    }
}
