
using BepInEx.Logging;
using MechClan.Upgrades;
using MonsterTrainModdingAPI;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI.Managers;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using System.Collections.Generic;
using MechClan.Cards.Mech;

namespace MechClan.Cards
{
    class Mechanical
    {
        public static string IDName = "MechVanguard";
        public static string imgName = "MechVanguard";

        public static void Make()
        {
            // Basic Card Stats 
            ChampionCardDataBuilder railyard = new ChampionCardDataBuilder
            {
                Cost = 0,
                Champion = BuildUnit(),
                ChampionIconPath = "ag88/Clan Assets/Icon_ClassSelect_Mech.png",
                ChampionSelectedCue = "",
                StarterCardData = CustomCardManager.GetCardDataByID(FlawedMech.IDName),
                UpgradeTree = new CardUpgradeTreeDataBuilder
                {
                    UpgradeTrees = new List<List<CardUpgradeDataBuilder>>
                    {
                        new List<CardUpgradeDataBuilder>
                        {
                            MechVanguardGuzzlerBasic.Builder(),
                            MechVanguardGuzzlerPremium.Builder(),
                            MechVanguardGuzzlerPro.Builder(),
                        },
                        new List<CardUpgradeDataBuilder>
                        {
                            MechVanguardSupporterBasic.Builder(),
                            MechVanguardSupporterPremium.Builder(),
                            MechVanguardSupporterPro.Builder(),
                        },
                        new List<CardUpgradeDataBuilder>
                        {
                            MechVanguardSweeperBasic.Builder(),
                            MechVanguardSweeperPremium.Builder(),
                            MechVanguardSweeperPro.Builder(),
                        },
                    },
                },

                CardID = IDName,
                NameKey = IDName + "_Name",
                OverrideDescriptionKey = IDName + "_Desc",
                LinkedClass = MechClan.getClan(),
                ClanID = Clan.IDName,

                CardPoolIDs = new List<string> { "AG88", UnitsAllBanner },
                CardType = CardType.Monster,
                TargetsRoom = true,

                AssetPath = Utils.rootPath + Utils.ucardPath,
            };

            Utils.AddImg(railyard, imgName + ".png");

            // Do this to complete
            railyard.BuildAndRegister();
        }

        // Builds the unit
        public static CharacterDataBuilder BuildUnit()
            {
                // Monster card, so we build an attached unit
                CharacterDataBuilder characterDataBuilder = new CharacterDataBuilder
                {
                    CharacterID = IDName,
                    NameKey = IDName + "_Name",

                    Size = 2,
                    Health = 10,
                    AttackDamage = 5,

                    //SubtypeKeys = new List<string> { "SubtypesData_Champion_83f21cbe-9d9b-4566-a2c3-ca559ab8ff34" },
                };

                Utils.AddUnitImg(characterDataBuilder, imgName + ".png");
                return characterDataBuilder;
            }
        
    }
}
