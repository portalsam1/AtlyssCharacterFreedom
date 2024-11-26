using System.Diagnostics.CodeAnalysis;
using BepInEx.Configuration;

namespace AtlyssCharacterFreedom
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    internal static class Configuration
    {

        public static readonly ConfigEntry<float> armMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "ArmMaximumRange", 105f, "The maximum value that the arm slider will produce in character menus.");
        public static readonly ConfigEntry<float> bellyMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BellyMaximumRange", 512f, "The maximum value that the belly slider will produce in character menus.");
        public static readonly ConfigEntry<float> boobMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BoobMaximumRange", 512f, "The maximum value that the boob slider will produce in character menus.");
        public static readonly ConfigEntry<float> pitchMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "PitchMaximumRange", 2f, "The maximum value that the pitch slider will produce in character menus.");
        public static readonly ConfigEntry<float> bottomMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BottomMaximumRange", 512f, "The maximum value that the bottom slider will produce in character menus.");
        public static readonly ConfigEntry<float> heightMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeightMaximumRange", 1.055f, "The maximum value that the height slider will produce in character menus.");
        public static readonly ConfigEntry<float> torsoMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "TorsoMaximumRange", 105f, "The maximum value that the torso slider will produce in character menus.");
        public static readonly ConfigEntry<float> widthMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "WidthMaximumRange", 1.15f, "The maximum value that the width slider will produce in character menus.");
        public static readonly ConfigEntry<float> headModMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeadModMaximumRange", 100f, "The maximum value that the head modification slider will produce in character menus.");
        public static readonly ConfigEntry<float> headWidthMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeadWidthMaximumRange", 1.15f, "The maximum value that the head width slider will produce in character menus.");
        
    }
}