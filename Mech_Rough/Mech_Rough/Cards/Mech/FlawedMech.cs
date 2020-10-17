using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;

namespace Mech_Rough.Cards.Mech
{
    class FlawedMech
    {
        public const string ID = "FlawedMech";
        public static CardData Make()
        {
            CardDataBuilder cardDataBuilder = new CardDataBuilder
            {
                CardID = ID
                Cost = 1,
                Rarity = CollectableRarity.Starter,
            };
            return cardDataBuilder.BuildAndRegister();
        }
    }
}
