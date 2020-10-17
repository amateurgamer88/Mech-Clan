using MechClan.Artifacts;
using MechClan.Cards;
using HarmonyLib;
using I2.Loc;
using MonsterTrainModdingAPI;
using MonsterTrainModdingAPI.Managers;
using MonsterTrainModdingAPI.Builders;
using System.Net.Sockets;
using UnityEngine;

namespace MechClan.Cards
{
    [HarmonyPatch(typeof(SaveManager), "SetupRun")]
    class AddToStartingDeck
    {
        // Adds cards to the starting deck
        static void Postfix(ref SaveManager __instance)
        {

            //__instance.AddRelic(__instance.GetAllGameData().FindCollectableRelicData(FirstBuffExtraStack.ID));
        }
    }

    [HarmonyPatch(typeof(CompendiumSectionCards), "IsCardUnlockedAndDiscovered")]
    class RevealAllCards
    {
        // Creates and registers card data for each card class
        static void Postfix(ref bool __result)
        {
            __result = true;
        }
    }

    //[HarmonyPatch(typeof(CardState), "Setup")]
    //class DebugCrashCards
    //{
    //    // Creates and registers card data for each card class
    //    static void Prefix(CardState __instance, CardData setCardData)
    //    {
    //        API.Log(BepInEx.Logging.LogLevel.All, "Processing Card: " + setCardData.GetID() + " - " + setCardData.GetNameKey());
    //    }
    //}

    //[HarmonyPatch(typeof(CardState), "SetupBodyStatusEffectsText")]
    //class DebugCrashCards
    //{
    //    // Creates and registers card data for each card class
    //    static void Prefix(CardState __instance)
    //    {
    //        API.Log(BepInEx.Logging.LogLevel.All, "Processing Card Status from: " + __instance.GetID() + " - " + __instance.GetAssetName());
    //    }
    //}
}

