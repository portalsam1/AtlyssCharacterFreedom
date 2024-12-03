using BepInEx.Configuration;

namespace AtlyssCharacterFreedom
{
    internal static class Configuration
    {

        public static ConfigEntry<float> ArmMinimumRange = null!;
        public static ConfigEntry<float> BellyMinimumRange = null!;
        public static ConfigEntry<float> BoobMinimumRange = null!;
        public static ConfigEntry<float> PitchMinimumRange = null!;
        public static ConfigEntry<float> BottomMinimumRange = null!;
        public static ConfigEntry<float> HeightMinimumRange = null!;
        public static ConfigEntry<float> TorsoMinimumRange = null!;
        public static ConfigEntry<float> WidthMinimumRange = null!;
        public static ConfigEntry<float> HeadModMinimumRange = null!;
        public static ConfigEntry<float> HeadWidthMinimumRange = null!;
        
        public static ConfigEntry<float> ArmMaximumRange = null!;
        public static ConfigEntry<float> BellyMaximumRange = null!;
        public static ConfigEntry<float> BoobMaximumRange = null!;
        public static ConfigEntry<float> PitchMaximumRange = null!;
        public static ConfigEntry<float> BottomMaximumRange = null!;
        public static ConfigEntry<float> HeightMaximumRange = null!;
        public static ConfigEntry<float> TorsoMaximumRange = null!;
        public static ConfigEntry<float> WidthMaximumRange = null!;
        public static ConfigEntry<float> HeadModMaximumRange = null!;
        public static ConfigEntry<float> HeadWidthMaximumRange = null!;

        public static ConfigEntry<bool> SafetyEnabled = null!;

        internal static void BindConfiguration()
        {
            ArmMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "ArmMinimumRange", -5f, "The minimum value that the arm slider will produce in character menus.");
            BellyMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "BellyMinimumRange", -20f, "The minimum value that the belly slider will produce in character menus.");
            BoobMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "BoobMinimumRange", -20f, "The minimum value that the boob slider will produce in character menus.");
            PitchMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "PitchMinimumRange", 0.5f, "The minimum value that the pitch slider will produce in character menus.");
            BottomMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "BottomMinimumRange", -50f, "The minimum value that the bottom slider will produce in character menus.");
            HeightMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "HeightMinimumRange", 0.05f, "The minimum value that the height slider will produce in character menus.");
            TorsoMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "TorsoMinimumRange", -10f, "The minimum value that the torso slider will produce in character menus.");
            WidthMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "WidthMinimumRange", 0.05f, "The minimum value that the width slider will produce in character menus.");
            HeadModMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "HeadModMinimumRange", 0f, "The minimum value that the head modification slider will produce in character menus.");
            HeadWidthMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "HeadWidthMinimumRange", 0.95f, "The minimum value that the head width slider will produce in character menus.");
        
            ArmMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "ArmMaximumRange", 105f, "The maximum value that the arm slider will produce in character menus.");
            BellyMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BellyMaximumRange", 512f, "The maximum value that the belly slider will produce in character menus.");
            BoobMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BoobMaximumRange", 512f, "The maximum value that the boob slider will produce in character menus.");
            PitchMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "PitchMaximumRange", 2f, "The maximum value that the pitch slider will produce in character menus.");
            BottomMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BottomMaximumRange", 512f, "The maximum value that the bottom slider will produce in character menus.");
            HeightMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeightMaximumRange", 1.5f, "The maximum value that the height slider will produce in character menus.");
            TorsoMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "TorsoMaximumRange", 105f, "The maximum value that the torso slider will produce in character menus.");
            WidthMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "WidthMaximumRange", 1.5f, "The maximum value that the width slider will produce in character menus.");
            HeadModMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeadModMaximumRange", 100f, "The maximum value that the head modification slider will produce in character menus.");
            HeadWidthMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeadWidthMaximumRange", 1.15f, "The maximum value that the head width slider will produce in character menus.");

            SafetyEnabled = CharacterFreedom.GetConfig().Bind("Safety", "SafetyEnabled", false, "Enables safety settings, clamping other players avatars to the sizes defined in your personal config.");
        }
        
    }
}
