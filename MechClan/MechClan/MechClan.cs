using BepInEx;
using MechClan.Artifacts;
using HarmonyLib;
using MonsterTrainModdingAPI;
using MonsterTrainModdingAPI.Interfaces;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI.Managers;
using MechClan.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace MechClan
{
    // Credit to Rawsome, Stable Infery for the base of this method.
    [BepInPlugin("ca.AG88.mech", "Mech Clan", "0.1")]
    [BepInProcess("MonsterTrain.exe")]
    [BepInProcess("MtLinkHandler.exe")]
    [BepInDependency("api.modding.train.monster")]
    public class MechClan : BaseUnityPlugin, IInitializable
    {
        public static ClassData clanRef;

        public void Initialize()
        {
            CustomLocalizationManager.ImportCSV("ag88/Mech.csv", ';');
            clanRef = Clan.Make();
            RegisterSubtypes();

            MakeCards();

            //foreach (var bundle in BundleManager.LoadedAssetBundles)
            //{
            //    API.Log(BepInEx.Logging.LogLevel.All, bundle.Value.GetAllAssetNames().Join());
            //}

            Mechanical.Make();
            SecondMech.Make();
            MakeArtifacts();
        }


        static void MakeArtifacts()
        {
            //var types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace.StartsWith("DiscipleClan.Artifacts") && !t.Name.Contains("<>"));

            //foreach (var relic in types) { API.Log(BepInEx.Logging.LogLevel.All, "Artifact Name: " + relic.Name);  Make(relic); }

            BarbedDefense.Make();
            Harvester.Make();
            ImprovedEngine.Make();
            IronPlate.Make();
            JunkRepairDrone.Make();
            MiniFactory.Make();
            OilSpill.Make();
            Overdrive.Make();
            Recycler.Make();
            VanguardsEmblem.Make();
        }

        static void MakeCards()
        {
            // CommonSpells
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace.StartsWith("MechClan.Cards.CommonSpells") && !t.Name.Contains("<>"));
            API.Log(BepInEx.Logging.LogLevel.All, "Making " + types.ToList().Count + " CommonSpells Cards");
            foreach (var card in types) { Make(card); }

            // Mech
            types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace.StartsWith("MechClan.Cards.Mech") && !t.Name.Contains("<>"));
            API.Log(BepInEx.Logging.LogLevel.All, "Making " + types.ToList().Count + " Mech Cards");
            foreach (var card in types) { Make(card); }

            // Mine
            types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace.StartsWith("MechClan.Cards.Mine") && !t.Name.Contains("<>"));
            API.Log(BepInEx.Logging.LogLevel.All, "Making " + types.ToList().Count + " Mine Cards");
            foreach (var card in types) { Make(card); }

            // RareSpells
            types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace.StartsWith("MechClan.Cards.RareSpells") && !t.Name.Contains("<>"));
            API.Log(BepInEx.Logging.LogLevel.All, "Making " + types.ToList().Count + " RareSpells Cards");
            foreach (var card in types) { Make(card); }

            // Token
            types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace.StartsWith("MechClan.Cards.Token") && !t.Name.Contains("<>"));
            API.Log(BepInEx.Logging.LogLevel.All, "Making " + types.ToList().Count + " Token Cards");
            foreach (var card in types) { Make(card); }

            // UncommonSpells
            types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace.StartsWith("MechClan.Cards.UncommonSpells") && !t.Name.Contains("<>"));
            API.Log(BepInEx.Logging.LogLevel.All, "Making " + types.ToList().Count + " UncommonSpells Cards");
            foreach (var card in types) { Make(card); }
        }

        public static void Make(Type cardType)
        {
            API.Log(BepInEx.Logging.LogLevel.All, "Making... " + cardType.Name);
            MethodInfo make = cardType.GetMethod("Make");
            make.Invoke(null, null);
        }

        public static ClassData getClan() { return clanRef; }

        public static void RegisterSubtypes()
        {
            CustomCharacterManager.RegisterSubtype("MechSubtype_Mech");
            CustomCharacterManager.RegisterSubtype("MechSubtype_Mine");
            CustomCharacterManager.RegisterSubtype("MechSubtype_Token");
        }

        public static void PrintCardStats()
        {
            int totalCards = 0;
            int commons = 0;
            int uncommons = 0;
            int rares = 0;
            int units = 0;
            int spells = 0;

            foreach (var card in CustomCardManager.CustomCardData)
            {
                totalCards++;
                if (card.Value.GetRarity() == CollectableRarity.Common)
                    commons++;
                if (card.Value.GetRarity() == CollectableRarity.Uncommon)
                    uncommons++;
                if (card.Value.GetRarity() == CollectableRarity.Rare)
                    rares++;
                if (card.Value.GetCardType() == CardType.Spell)
                    spells++;
                if (card.Value.GetCardType() == CardType.Monster)
                    units++;
            }

            API.Log(BepInEx.Logging.LogLevel.All, "Total Cards: " + totalCards);
            API.Log(BepInEx.Logging.LogLevel.All, "Common Cards: " + commons);
            API.Log(BepInEx.Logging.LogLevel.All, "Uncommon Cards: " + uncommons);
            API.Log(BepInEx.Logging.LogLevel.All, "Rare Cards: " + rares);
            API.Log(BepInEx.Logging.LogLevel.All, "Units: " + units);
            API.Log(BepInEx.Logging.LogLevel.All, "Spell Cards: " + spells);
        }
    }
}
