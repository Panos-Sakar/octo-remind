namespace OctoRE.Core
{
    public static class ResourceManager
    {
        private const string ResourcePack = "pack://application:,,,";
        private const string IconsFolderPrefix = "/Assets/Icons/";

        public static string GetPackedPath(string path)
        {
            return $"{ResourcePack}{path}";
        }

        public static string GetDefaultIconPath()
        {
            return GetPackedPath($"{IconsFolderPrefix}gear.png");
        }

        public static string GetIconUriPath(string iconName)
        {
            return $"{IconsFolderPrefix}{iconName}";
        }

        public static string GetIconUriPath(RegisteredIcons icon)
        {
            return $"{IconsFolderPrefix}{GetRegisteredIconName(icon)}";
        }

        private static string GetRegisteredIconName(RegisteredIcons icon)
        {
            return icon switch
            {
                RegisteredIcons.Default => "gear.png",
                RegisteredIcons.Alarm => "alarm.png",
                RegisteredIcons.AlarmBlack => "alarm-black.png",
                RegisteredIcons.Gear => "gear.png",
                RegisteredIcons.GearBlack => "gear-black.png",
                _ => ""
            };
        }
    }

    public enum RegisteredIcons
    {
        Default,
        Alarm,
        AlarmBlack,
        Gear,
        GearBlack
    }
}
