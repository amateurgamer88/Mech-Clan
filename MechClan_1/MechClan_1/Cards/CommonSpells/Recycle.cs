using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MechClan_1.Cards.CommonSpells
{
    class Recycle
    {
        //unique ID (GUID can make this unique from other same name cards)
        public static string ID = AGMech.GUID + "Recycle";


        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                //Name of the card
                Name = "Recycle",
                //Description of what this card does 
                Description = "Rear unit gains [spark] <b>1</b>",
                //Card ID
                CardID = Recycle.ID,
                //Ember cost of this card
                Cost = 1,
                //rarity of this card (Starter, Common, Uncommon and Rare)
                Rarity = CollectableRarity.Common,
                //Pick the clan for this card (clanless for this card)
                ClanID = VanillaClanIDs.Awoken,
                //path to the picture for this card
                AssetPath = "assets/amateur.png",
                //card pool this card belongs to
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                //what does this card do?
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = typeof(CardEffectSacrifice),
                        ParamInt = 100,
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Monsters,
                    },

                    new CardEffectDataBuilder
                    {
                        EffectStateType = typeof(CardEffectAddStatusEffect),
                        ParamInt = 100,
                        TargetMode = TargetMode.BackInRoom,
                        TargetTeamType = Team.Type.Monsters,
                        ParamStatusEffects = new StatusEffectStackData[] { new StatusEffectStackData { statusId= "spark", count=1} }
                    }
                },

            };

            //Do this to complete the card building
            railyard.BuildAndRegister();

        }
    }
}
