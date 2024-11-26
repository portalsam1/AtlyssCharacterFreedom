using BepInEx.Configuration;

namespace AtlyssCharacterFreedom
{
    internal static class Configuration
    {

        // I think if people change these then other people with the mod probably aren't able to see them unless their config is the same / has the number, I don't know if there's any good solution to this.
        public static readonly ConfigEntry<float> ArmMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "ArmMinimumRange", -5f, "The minimum value that the arm slider will produce in character menus.");
        public static readonly ConfigEntry<float> BellyMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "BellyMinimumRange", -20f, "The minimum value that the belly slider will produce in character menus.");
        public static readonly ConfigEntry<float> BoobMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "BoobMinimumRange", -20f, "The minimum value that the boob slider will produce in character menus.");
        public static readonly ConfigEntry<float> PitchMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "PitchMinimumRange", 0.5f, "The minimum value that the pitch slider will produce in character menus.");
        public static readonly ConfigEntry<float> BottomMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "BottomMinimumRange", -50f, "The minimum value that the bottom slider will produce in character menus.");
        public static readonly ConfigEntry<float> HeightMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "HeightMinimumRange", 0.05f, "The minimum value that the height slider will produce in character menus.");
        public static readonly ConfigEntry<float> TorsoMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "TorsoMinimumRange", -10f, "The minimum value that the torso slider will produce in character menus.");
        public static readonly ConfigEntry<float> WidthMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "WidthMinimumRange", 0.05f, "The minimum value that the width slider will produce in character menus.");
        public static readonly ConfigEntry<float> HeadModMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "HeadModMinimumRange", 0f, "The minimum value that the head modification slider will produce in character menus.");
        public static readonly ConfigEntry<float> HeadWidthMinimumRange = CharacterFreedom.GetConfig().Bind("MinimumValues", "HeadWidthMinimumRange", 0.95f, "The minimum value that the head width slider will produce in character menus.");
        
        public static readonly ConfigEntry<float> ArmMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "ArmMaximumRange", 105f, "The maximum value that the arm slider will produce in character menus.");
        public static readonly ConfigEntry<float> BellyMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BellyMaximumRange", 512f, "The maximum value that the belly slider will produce in character menus.");
        public static readonly ConfigEntry<float> BoobMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BoobMaximumRange", 512f, "The maximum value that the boob slider will produce in character menus.");
        public static readonly ConfigEntry<float> PitchMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "PitchMaximumRange", 2f, "The maximum value that the pitch slider will produce in character menus.");
        public static readonly ConfigEntry<float> BottomMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "BottomMaximumRange", 512f, "The maximum value that the bottom slider will produce in character menus.");
        public static readonly ConfigEntry<float> HeightMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeightMaximumRange", 1.5f, "The maximum value that the height slider will produce in character menus.");
        public static readonly ConfigEntry<float> TorsoMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "TorsoMaximumRange", 105f, "The maximum value that the torso slider will produce in character menus.");
        public static readonly ConfigEntry<float> WidthMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "WidthMaximumRange", 1.5f, "The maximum value that the width slider will produce in character menus.");
        public static readonly ConfigEntry<float> HeadModMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeadModMaximumRange", 100f, "The maximum value that the head modification slider will produce in character menus.");
        public static readonly ConfigEntry<float> HeadWidthMaximumRange = CharacterFreedom.GetConfig().Bind("MaximumValues", "HeadWidthMaximumRange", 1.15f, "The maximum value that the head width slider will produce in character menus.");
        
    }
}
