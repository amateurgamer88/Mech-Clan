using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MechClan_1.Cards.Mech
{
    class MechGuard
    {
        //unique ID (GUID can make this unique from other same name cards)
        public static string ID = AGMech.GUID + "MechGuard";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                //Card ID
                CardID = MechGuard.ID,

                //Description of what this card does 
                Description = "<b>Summon:</b> Apply [armor] <b>20</b> to front friendly unit.",
                //Ember cost of this card
                Cost = 2,
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
                    EffectStateType = typeof(CardEffectSpawnMonster),
                    TargetMode = TargetMode.DropTargetCharacter,
                    ParamCharacterDataBuilder = new CharacterDataBuilder
                    {
                        CharacterID = MechGuard.ID,
                        Name = "Mech Guard",
                        Size = 2,
                        Health = 10,
                        AttackDamage = 0,
                        AssetPath = "assets/amateur.png",
                        SubtypeKeys = new List<string> { "MechSubtype_Mech" },

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
                                        EffectStateType = typeof(CardEffectAddStatusEffect),
                                        TargetMode = TargetMode.FrontInRoom,
                                        TargetTeamType = Team.Type.Monsters,
                                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "armor", count=20} }
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
