using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;

namespace MechClan_1.Cards.Mech
{
    class Card1
    {
        public const string ID = "MODNAME_Card1";
        public static CardData Make()
        {
            CardDataBuilder cardDataBuilder = new CardDataBuilder
            {
                CardID = ID
            };
            return cardDataBuilder.BuildAndRegister();
        }
    }
}
