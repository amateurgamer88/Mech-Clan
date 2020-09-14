using MechClan.Upgrades;
using HarmonyLib;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI.Managers;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MechClan
{
    class Clan
    {
        public static string IDName = "Mech";

        public static ClassData Make()
        {
            ClassDataBuilder clan = new ClassDataBuilder
            {
                ClassID = IDName,
                DraftIconPath = "ag88/Clan Assets/Icon_CardBack_Mech.png",

                IconAssetPaths = new List<string>
                {
                    "ag88/Clan Assets/ClanLogo_92_stroke1.png", // Clan Choice Icon
                    "ag88/Clan Assets/ClanLogo_92_stroke2.png", // Also compendium...? 56x56
                    "ag88/Clan Assets/ClanLogo_92_stroke1.png", // Large Coloured Icon
                    "ag88/Clan Assets/ClanLogo_silhouette.png", // Compendium Silhouette 56x56
                },

                CardFrameUnitPath = "ag88/Clan Assets/unit-cardframe-arcadian.png",
                CardFrameSpellPath = "ag88/Clan Assets/spell-cardframe-arcadian.png",

                UiColor = new Color(0.964f, 0.729f, 0.015f, 1f),
                UiColorDark = new Color(0.12f, 0.375f, 0.5f, 1f),
            };

            return clan.BuildAndRegister();
        }

    }
}
