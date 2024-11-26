﻿using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using HarmonyLib;

namespace AtlyssCharacterFreedom
{
    // This class uncaps the sliders in the character creation menu.
    [HarmonyPatch(typeof(CharacterCreationManager), "Handle_CharacterCreationDisplay")] [SuppressMessage("ReSharper", "InconsistentNaming")] [SuppressMessage("ReSharper", "UnusedMember.Local")]
    internal class CharacterCreationManagerPatch
    {

        private static readonly CharacterParamsGroup templateParamsGroup = new CharacterParamsGroup();
        
        private static void Prefix(CharacterCreationManager __instance)
        {
            PlayerRaceModel? model = __instance.GetType().GetField("_currentRaceModel", BindingFlags.Instance | BindingFlags.NonPublic)!.GetValue(__instance) as PlayerRaceModel;
            model!._scriptablePlayerRace._raceDisplayParams = templateParamsGroup;
        }
        
    }
}