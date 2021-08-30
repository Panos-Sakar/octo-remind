using System.Drawing;

namespace OctoRE.Core.Models
{
    public class SidebarItemModel
    {
        private const string ResourcePrefix = "/Assets/Icons/";
        public string ItemName { get; set; }
        public string Subtext { get; set; }
        public Color ItemColor { get; set; }
        public string IconSource { get; set; }


        public SidebarItemModel(string itemName, string subtext, Color itemColor, string iconSource)
        {
            ItemName = itemName;
            Subtext = subtext;
            ItemColor = itemColor;
            IconSource = $"{ResourcePrefix}{iconSource}";
        }
    }
}
