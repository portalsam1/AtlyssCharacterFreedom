using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;
using System.Diagnostics.CodeAnalysis;

namespace AtlyssCharacterFreedom
{
    
    [SuppressMessage("ReSharper", "UnusedMember.Local")] [SuppressMessage("ReSharper", "UnusedType.Global")]
    [BepInPlugin("net.portalsam.AtlyssCharacterFreedom", "CharacterFreedom", "1.2.0.0")]
    [BepInProcess("ATLYSS.exe")]
    public class CharacterFreedom : BaseUnityPlugin
    {

        internal static CharacterFreedom Instance = null!;
        internal new static ManualLogSource Logger { get; private set; } = null!;

        private void Awake()
        {
            Instance = this;
            Logger = base.Logger;
            
            Configuration.BindConfiguration();
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
            
            Logger.LogInfo("CharacterFreedom has been initialized!");
        }

        internal static ConfigFile GetConfig() => Instance.Config;
        
    }
    
}