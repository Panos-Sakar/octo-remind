using System;

namespace OctoRE.Core
{
    public static class ResourceManager
    {
        private const string ResourcePack = "pack://application:,,,";
        private const string IconsFolderPrefix = "/Assets/Icons/";
        public static string GetDefaultIconPath()
        {
            return $"{ResourcePack}{IconsFolderPrefix}gear.png";
        }

        public static string GetIconUriPath(string iconName)
        {
            return $"{ResourcePack}{IconsFolderPrefix}{iconName}.png";
        }

        public static string GetIconUriPath(RegisteredIcons icon)
        {
            return $"{ResourcePack}{IconsFolderPrefix}{GetRegisteredIconName(icon)}.png";
        }

        private static string GetRegisteredIconName(RegisteredIcons icon)
        {
            switch (icon)
            {
                case RegisteredIcons.Default:
                    return "gear";
                case RegisteredIcons.Alarm:
                    return "alarm";
                case RegisteredIcons.AlarmBlack:
                    return "alarm-black";
                case RegisteredIcons.Gear:
                    return "gear";
                case RegisteredIcons.GearBlack:
                    return "gear-black";
                default:
                    return "";
            }
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
