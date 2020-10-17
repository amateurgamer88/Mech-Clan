using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MechClan_1.Cards.Mech
{
    class FlawedMech
    {
        //unique ID (GUID can make this unique from other same name cards)
        public static string ID = AGMech.GUID + "FlawedMech";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                //Card ID
                CardID = FlawedMech.ID,

                //Description of what this card does 
                Description = "<b>Resolve:</b> -3 [attack]",
                //Ember cost of this card
                Cost = 1,
                //rarity of this card (Starter, Common, Uncommon and Rare)
                Rarity = CollectableRarity.Starter,
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
                    EffectStateType = typeof(CardEffectSpawnMonster),
                    TargetMode = TargetMode.DropTargetCharacter,
                    ParamCharacterDataBuilder = new CharacterDataBuilder
                    {
                        CharacterID = FlawedMech.ID,
                        Name = "Flawed Mech",
                        Size = 2,
                        Health = 5,
                        AttackDamage = 12,
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
                                        EffectStateType = typeof(CardEffectAddTempCardUpgradeToUnits),
                                        TargetMode = TargetMode.Self,
                                        ParamCardUpgradeData = new CardUpgradeDataBuilder
                                        {
                                            BonusDamage = -3,
                                            HideUpgradeIconOnCard = true,
                                        }.Build(),
                                    },
                                }
                            }
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
