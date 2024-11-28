using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using HarmonyLib;

namespace AtlyssCharacterFreedom
{
    // This class uncaps the sliders in the character creation menu.
    [HarmonyPatch(typeof(CharacterCreationManager), "Handle_CharacterCreationDisplay")] [SuppressMessage("ReSharper", "InconsistentNaming")] [SuppressMessage("ReSharper", "UnusedMember.Local")]
    internal static class CharacterCreationManagerPatch
    {

        private static readonly CharacterParamsGroup templateParamsGroup = new CharacterParamsGroup();
        
        private static void Prefix(CharacterCreationManager __instance)
        {
            // Just realized this function probably runs a lot, this is probably not performant.
            PlayerRaceModel? model = __instance.GetType().GetField("_currentRaceModel", BindingFlags.Instance | BindingFlags.NonPublic)!.GetValue(__instance) as PlayerRaceModel;
            model!._scriptablePlayerRace._raceDisplayParams = templateParamsGroup;
        }
        
    }
}