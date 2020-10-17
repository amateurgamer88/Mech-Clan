using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MechClan_1.Cards.Mech
{
    class MechGoliath
    {
        //unique ID (GUID can make this unique from other same name cards)
        /*public static string ID = AGMech.GUID + "MechGoliath";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                //Card ID
                CardID = MechGoliath.ID,

                //Description of what this card does 
                Description = " <b>Multistrike 1</b>. <b>Slay:</b> +5 [attack] permanently.",
                //Ember cost of this card
                Cost = 4,
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
                        CharacterID = MechGoliath.ID,
                        Name = "Mech Goliath",
                        Size = 4,
                        Health = 25,
                        AttackDamage = 30,
                        AssetPath = "assets/amateur.png",
                        SubtypeKeys = new List<string> { "MechSubtype_Mech" },

                        StartingStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { count = 1, statusId = "inert" } },

                        TriggerBuilders = new List<CharacterTriggerDataBuilder>
                        {

                            new CharacterTriggerDataBuilder
                            {
                            Trigger = CharacterTriggerData.Trigger.OnKill,
                            EffectBuilders = new List<CardEffectDataBuilder>
                                {
                                    new CardEffectDataBuilder
                                    {
                                        EffectStateType =  typeof(CardTriggerEffectBuffCharacterDamage),
                                        TargetMode = TargetMode.Self,

                                         ParamCardUpgradeData = new CardUpgradeDataBuilder
                                        {
                                            BonusDamage = 5,
                                            HideUpgradeIconOnCard = true,
                                        }.Build(),
                                    },
                                }
                            }
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
