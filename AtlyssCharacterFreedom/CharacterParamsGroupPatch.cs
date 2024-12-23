﻿using System;
using System.Diagnostics.CodeAnalysis;
using HarmonyLib;

namespace AtlyssCharacterFreedom
{
    [HarmonyPatch(typeof(CharacterParamsGroup), MethodType.Constructor, new Type[] { })] [SuppressMessage("ReSharper", "InconsistentNaming")] [SuppressMessage("ReSharper", "UnusedMember.Local")]
    internal static class CharacterParamsGroupPatch
    {
        private static void Postfix(CharacterParamsGroup __instance)
        {
            __instance._armRange.x = Configuration.ArmMinimumRange.Value;
            __instance._bellyRange.x = Configuration.BellyMinimumRange.Value;
            __instance._boobRange.x = Configuration.BoobMinimumRange.Value;
            __instance._pitchRange.x = Configuration.PitchMinimumRange.Value;
            __instance._bottomRange.x = Configuration.BottomMinimumRange.Value;
            __instance._heightRange.x = Configuration.HeightMinimumRange.Value;
            __instance._torsoRange.x = Configuration.TorsoMinimumRange.Value;
            __instance._widthRange.x = Configuration.WidthMinimumRange.Value;
            __instance._headModRange.x = Configuration.HeadModMinimumRange.Value;
            __instance._headWidthRange.x = Configuration.HeadWidthMinimumRange.Value;
            
            __instance._armRange.y = Configuration.ArmMaximumRange.Value;
            __instance._bellyRange.y = Configuration.BellyMaximumRange.Value;
            __instance._boobRange.y = Configuration.BoobMaximumRange.Value;
            __instance._pitchRange.y = Configuration.PitchMaximumRange.Value;
            __instance._bottomRange.y = Configuration.BottomMaximumRange.Value;
            __instance._heightRange.y = Configuration.HeightMaximumRange.Value;
            __instance._torsoRange.y = Configuration.TorsoMaximumRange.Value;
            __instance._widthRange.y = Configuration.WidthMaximumRange.Value;
            __instance._headModRange.y = Configuration.HeadModMaximumRange.Value;
            __instance._headWidthRange.y = Configuration.HeadWidthMaximumRange.Value;
        }
    }
}
