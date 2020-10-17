using BepInEx;
using HarmonyLib;
using MonsterTrainModdingAPI.Interfaces;
using MonsterTrainModdingAPI.Managers;
using MT_Tutorial_Examples.Cards;
using System;


[BepInPlugin("com.name.package.generic", "Test Plugin", "0.1.0")]
[BepInProcess("MonsterTrain.exe")]
[BepInProcess("MtLinkHandler.exe")]
[BepInDependency("api.modding.train.monster")]
public class TestPlugin : BaseUnityPlugin, IInitializable
{
    public const string GUID = "AG Tut";
    public const string NAME = "Tutorial Examples";
    public const string VERSION = "0.1.0";
    private void Awake()
    {
        var harmony = new Harmony("AG Tut");
        harmony.PatchAll();
    }

    public void Initialize()
    {
        Spell1.Make();
        Monster1.Make();
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
        __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(Spell1.ID));
    }
}