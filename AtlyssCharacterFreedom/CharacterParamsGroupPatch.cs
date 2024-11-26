using System;
using System.Diagnostics.CodeAnalysis;
using HarmonyLib;

namespace AtlyssCharacterFreedom
{
    [HarmonyPatch(typeof(CharacterParamsGroup), MethodType.Constructor, new Type[] { })] [SuppressMessage("ReSharper", "InconsistentNaming")] [SuppressMessage("ReSharper", "UnusedMember.Local")]
    internal class CharacterParamsGroupPatch
    {
        private static void Postfix(CharacterParamsGroup __instance)
        {
            __instance._armRange.y = Configuration.armMaximumRange.Value;
            __instance._bellyRange.y = Configuration.bellyMaximumRange.Value;
            __instance._boobRange.y = Configuration.boobMaximumRange.Value;
            __instance._pitchRange.y = Configuration.pitchMaximumRange.Value;
            __instance._bottomRange.y = Configuration.bottomMaximumRange.Value;
            __instance._heightRange.y = Configuration.heightMaximumRange.Value;
            __instance._torsoRange.y = Configuration.torsoMaximumRange.Value;
            __instance._widthRange.y = Configuration.widthMaximumRange.Value;
            __instance._headModRange.y = Configuration.headModMaximumRange.Value;
            __instance._headWidthRange.y = Configuration.headWidthMaximumRange.Value;
        }
    }
}
