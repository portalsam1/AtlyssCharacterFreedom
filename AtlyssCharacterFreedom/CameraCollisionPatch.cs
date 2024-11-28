using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
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
                
                MethodInfo calculateCameraClampMethod = AccessTools.Method(typeof(CameraCollisionPatch), nameof(CalculateCameraClamp), new[] { typeof(CameraCollision) });
                
                List<CodeInstruction> newInstructions = new List<CodeInstruction>
                {
                   // CameraCollisionPatch.CalculateCameraClamp(this);
                   new CodeInstruction(OpCodes.Ldarg_0),
                   new CodeInstruction(OpCodes.Call, calculateCameraClampMethod)
                };
                
                code.InsertRange(maxIndex - 2, newInstructions);

                return code.AsEnumerable();
            }
        }
        
        public static void CalculateCameraClamp(CameraCollision instance)
        { 
            float calculatedMax = Player._mainPlayer._pVisual._playerAppearanceStruct._heightWeight.Remap(1, 100, 60, 1500);
            if(instance.maxDistance > calculatedMax)
                instance.maxDistance = calculatedMax;
        }
        
    }
}
