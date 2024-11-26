using System.Diagnostics.CodeAnalysis;
using HarmonyLib;

namespace AtlyssCharacterFreedom
{
    [HarmonyPatch(typeof(ScriptablePlayerRace), "Init_ParamsCheck")] [SuppressMessage("ReSharper", "InconsistentNaming")] [SuppressMessage("ReSharper", "UnusedMember.Local")] [SuppressMessage("ReSharper", "RedundantAssignment")]
    internal static class ScriptablePlayerRacePatch
    {
        
        private static bool Prefix(ScriptablePlayerRace __instance, ref PlayerAppearance_Profile __result, PlayerAppearance_Profile _aP)
        {
            
            // No clamping at all, might be redundant.
            CharacterParamsGroup patchedParamsGroup = new CharacterParamsGroup();
            __instance._raceDisplayParams = patchedParamsGroup;
            
            __result = _aP;
            return false;

        }
        
    }
}
