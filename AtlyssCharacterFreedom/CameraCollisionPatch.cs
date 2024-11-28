using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Emit;
using HarmonyLib;
using UnityEngine;

namespace AtlyssCharacterFreedom
{
    public static class CameraCollisionPatch
    {
        [HarmonyPatch(typeof(CameraCollision), "LateUpdate")] [SuppressMessage("ReSharper", "InconsistentNaming")] [SuppressMessage("ReSharper", "UnusedMember.Local")]
        public static class CameraCollisionTranspilerPatch
        {
            private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                List<CodeInstruction> code = new List<CodeInstruction>(instructions);

                int maxIndex = -1;
                bool foundMax = false;
            
                for (int i = 0; i < code.Count - 1; i++)
                {
                    if (code[i].opcode == OpCodes.Ldc_R4 && code[i].operand is float operand)
                    {
                        if(!foundMax && Mathf.Approximately(operand, 60f)) { maxIndex = i; foundMax = true; }
                    }
                    if (maxIndex != -1) break;
                }
            
                // I tried to remove the minimum check but no matter what I did it would cause some Label error, someone smarter needs to take a look at this and propose something that works.
                code.RemoveRange(maxIndex - 2, 7);

                return code.AsEnumerable();
            }
        }
        [HarmonyPatch(typeof(CameraCollision), "Handle_DistanceControl")] [SuppressMessage("ReSharper", "InconsistentNaming")] [SuppressMessage("ReSharper", "UnusedMember.Local")]
        public static class CameraCollisionDistanceControlPatch
        {
            private static void Postfix(CameraCollision __instance)
            {
                if (Player._mainPlayer == null) return;
            
                float calculatedMax = Player._mainPlayer._pVisual._playerAppearanceStruct._heightWeight.Remap(1, 100, 60, 1500);
                if(__instance.maxDistance > calculatedMax)
                    __instance.maxDistance = calculatedMax;
            
                CharacterFreedom.Logger.LogInfo($"{calculatedMax} {__instance.maxDistance}");
            }
        }
    }
}