using BepInEx.Configuration;

namespace AtlyssCharacterFreedom
{
    internal static class Configuration
    {

        public static readonly ConfigEntry<float> ArmMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "ArmMaximumRange", 105f, "The maximum value that the arm slider will produce in character menus.");
        public static readonly ConfigEntry<float> BellyMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BellyMaximumRange", 512f, "The maximum value that the belly slider will produce in character menus.");
        public static readonly ConfigEntry<float> BoobMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BoobMaximumRange", 512f, "The maximum value that the boob slider will produce in character menus.");
        public static readonly ConfigEntry<float> PitchMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "PitchMaximumRange", 2f, "The maximum value that the pitch slider will produce in character menus.");
        public static readonly ConfigEntry<float> BottomMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BottomMaximumRange", 512f, "The maximum value that the bottom slider will produce in character menus.");
        public static readonly ConfigEntry<float> HeightMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeightMaximumRange", 1.055f, "The maximum value that the height slider will produce in character menus.");
        public static readonly ConfigEntry<float> TorsoMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "TorsoMaximumRange", 105f, "The maximum value that the torso slider will produce in character menus.");
        public static readonly ConfigEntry<float> WidthMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "WidthMaximumRange", 1.15f, "The maximum value that the width slider will produce in character menus.");
        public static readonly ConfigEntry<float> HeadModMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeadModMaximumRange", 100f, "The maximum value that the head modification slider will produce in character menus.");
        public static readonly ConfigEntry<float> HeadWidthMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeadWidthMaximumRange", 1.15f, "The maximum value that the head width slider will produce in character menus.");
        
    }
}
