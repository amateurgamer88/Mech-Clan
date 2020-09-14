
using BepInEx.Logging;
using MechClan.Upgrades;
using MonsterTrainModdingAPI;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI.Managers;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using System.Collections.Generic;
using MechClan.Cards;
using MechClan.Cards.CommonSpells;

namespace MechClan.Cards
{
    class SecondMech
    {
        public static string IDName = "MechTower";
        public static string imgName = "MechTower";

        public static void Make()
        {
            // Basic Card Stats 
            ChampionCardDataBuilder railyard = new ChampionCardDataBuilder
            {
                Cost = 0,
                Champion = BuildUnit(),
                ChampionIconPath = "ag88/Clan Assets/Icon_ClassSelect_Mech.png",
                ChampionSelectedCue = "",
                StarterCardData = CustomCardManager.GetCardDataByID(Recycle.IDName),
                UpgradeTree = new CardUpgradeTreeDataBuilder
                {
                    UpgradeTrees = new List<List<CardUpgradeDataBuilder>>
                    {
                        new List<CardUpgradeDataBuilder>
                        {
                            MechTowerHarvesterBasic.Builder(),
                            MechTowerHarvesterPremium.Builder(),
                            MechTowerHarvesterPro.Builder(),
                        },
                        new List<CardUpgradeDataBuilder>
                        {
                            MechTowerMinelayerBasic.Builder(),
                            MechTowerMinelayerPremium.Builder(),
                            MechTowerMinelayerPro.Builder(),
                        },
                        new List<CardUpgradeDataBuilder>
                        {
                            MechTowerSwarmerBasic.Builder(),
                            MechTowerSwarmerPremium.Builder(),
                            MechTowerSwarmerPro.Builder(),
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

                Size = 3,
                Health = 20,
                AttackDamage = 0,

                //SubtypeKeys = new List<string> { "SubtypesData_Champion_83f21cbe-9d9b-4566-a2c3-ca559ab8ff34" },
            };

            Utils.AddUnitImg(characterDataBuilder, imgName + ".png");
            return characterDataBuilder;
        }

    }
}
