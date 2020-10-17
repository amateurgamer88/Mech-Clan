using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;

namespace MechClan.Cards
{
    class Utils
    {
        public static string rootPath = "mech/";
        public static string ucardPath = "Card Assets/MechUnitCardArt/";
        public static string scardPath = "Card Assets/MechArt/";
        public static string unitPath = "Unit Assets/";
        public static string relicPath = "Relic/";

        public static void AddSpell(CardDataBuilder r, string IDName)
        {
            r.CardID = IDName;
            r.NameKey = IDName + "_Name";
            r.OverrideDescriptionKey = IDName + "_Desc";
            r.LinkedClass = MechClan.getClan();

            r.ClanID = Clan.IDName;
            r.CardPoolIDs = new List<string> { "Mech", MegaPool };

            r.AssetPath = rootPath + scardPath;

            if (!r.NameKey.HasTranslation())
                API.Log(BepInEx.Logging.LogLevel.All, r.NameKey + ",Text,,,,," + r.CardID + ",,,,,");
            if (!r.OverrideDescriptionKey.HasTranslation())
                API.Log(BepInEx.Logging.LogLevel.All, r.OverrideDescriptionKey + ",Text,,,,,<desc>,,,,,");

            //API.Log(BepInEx.Logging.LogLevel.All, string.Join("\t", new string[] { "Spell", r.NameKey.Localize(), r.Rarity.ToString(), r.Cost.ToString(), r.OverrideDescriptionKey.Localize() }));
        }

        public static void AddRelic(CollectableRelicDataBuilder r, string ID)
        {
            r.CollectableRelicID = ID;
            r.NameKey = ID + "_Name";
            r.DescriptionKey = ID + "_Desc";
            r.RelicActivatedKey = ID + "_Active";
            r.RelicLoreTooltipKeys = new List<string> { ID + "_Lore" };
            r.ClanID = "Mech";
            r.Rarity = CollectableRarity.Common;
            r.IsBossGivenRelic = false;

            if (!r.NameKey.HasTranslation())
                API.Log(BepInEx.Logging.LogLevel.All, r.NameKey + ",Text,,,,," + ID + ",,,,,");
            if (!r.DescriptionKey.HasTranslation())
                API.Log(BepInEx.Logging.LogLevel.All, r.DescriptionKey + ",Text,,,,,<desc>,,,,,");
            if (!r.RelicActivatedKey.HasTranslation())
                API.Log(BepInEx.Logging.LogLevel.All, r.RelicActivatedKey + ",Text,,,,,<desc>,,,,,");
            if (!r.RelicLoreTooltipKeys[0].HasTranslation())
                API.Log(BepInEx.Logging.LogLevel.All, r.RelicLoreTooltipKeys[0] + ",Text,,,,,<desc>,,,,,");
        }

        public static void AddUnit(CardDataBuilder r, string IDName, CharacterData character)
        {
            r.CardID = IDName;
            r.NameKey = IDName + "_Name";
            r.OverrideDescriptionKey = IDName + "_Desc";
            r.LinkedClass = MechClan.getClan();
            r.ClanID = Clan.IDName;

            r.CardPoolIDs = new List<string> { "Mech", UnitsAllBanner };
            r.CardType = CardType.Monster;
            r.TargetsRoom = true;

            r.AssetPath = rootPath + ucardPath;

            if (!r.NameKey.HasTranslation())
                API.Log(BepInEx.Logging.LogLevel.All, r.NameKey + ",Text,,,,," + r.CardID + ",,,,,");
            if (!r.OverrideDescriptionKey.HasTranslation())
                API.Log(BepInEx.Logging.LogLevel.All, r.OverrideDescriptionKey + ",Text,,,,,<desc>,,,,,");

            //API.Log(BepInEx.Logging.LogLevel.All, string.Join("\t", new string[] { "Unit", r.NameKey.Localize(), r.Rarity.ToString(), r.Cost.ToString(), character.GetSize().ToString(), character.GetHealth().ToString(), character.GetAttackDamage().ToString(), character.GetLocalizedSubtype(), r.OverrideDescriptionKey.Localize() }));
        }


        public static void AddImg(CardDataBuilder r, string imgName)
        {
            r.AssetPath = r.AssetPath + imgName;
        }

        public static void AddUnitImg(CharacterDataBuilder r, string imgName)
        {
            r.AssetPath = rootPath + unitPath + imgName;
        }
    }
}
