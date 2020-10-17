using BepInEx;
using HarmonyLib;
using MonsterTrainModdingAPI.Interfaces;
using MonsterTrainModdingAPI.Managers;
using MechClan_1.Cards;
using System;
using MechClan_1.Cards.Mech;
using MechClan_1.Cards.CommonSpells;

[BepInPlugin("com.name.package.generic", "AG Mech", "5.3")]
[BepInProcess("MonsterTrain.exe")]
[BepInProcess("MtLinkHandler.exe")]
[BepInDependency("api.modding.train.monster")]
public class AGMech : BaseUnityPlugin, IInitializable
{
    public const string GUID = "AG_Mech";
    public const string NAME = "Mech Clan";
    public const string VERSION = "0.1.0";
    private void Awake()
    {
        var harmony = new Harmony("AG Mech");
        harmony.PatchAll();
    }

    public void Initialize()
    {
        FlawedMech.Make();
        /*MechEnforcer.Make();
        Recycle.Make();
        MechFortress.Make();
        MechGoliath.Make();*/
        MechGuard.Make();/*
        MechGunner.Make();
        MechRefiner.Make();*/
        RegisterSubtypes();
    }

    public static void RegisterSubtypes()
    {
        CustomCharacterManager.RegisterSubtype("MechSubtype_Mech");
        CustomCharacterManager.RegisterSubtype("MechSubtype_Token");
        CustomCharacterManager.RegisterSubtype("MechSubtype_Mine");

    }
}



[HarmonyPatch(typeof(MetagameSaveData), "HasDiscoveredCard", new Type[] { typeof(CardData) })]
class ShowAllLogbookCardsPatch
{
    static bool Prefix(ref bool __result)
    {
        __result = true;
        return false;
    }
}

[HarmonyPatch(typeof(MetagameSaveData), "HasDiscoveredCard", new Type[] { typeof(string) })]
class ShowAllLogbookCardsPatch2
{
    static bool Prefix(ref bool __result)
    {
        __result = true;
        return false;
    }
}

[HarmonyPatch(typeof(SaveManager), "SetupRun")]
class AddCardToStartingDeckPatch
{
    static void Postfix(ref SaveManager __instance)
    {
        __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(FlawedMech.ID));
        /*__instance.AddCardToDeck(CustomCardManager.GetCardDataByID(MechEnforcer.ID));
        __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(MechFortress.ID));
        __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(MechGoliath.ID));*/
        __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(MechGuard.ID));/*
        __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(Recycle.ID));*/
    }
}