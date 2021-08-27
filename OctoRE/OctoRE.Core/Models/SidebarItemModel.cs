using System.Drawing;

namespace OctoRE.Core.Models
{
    public class SidebarItemModel
    {
        public string ItemName { get; set; }
        public string Subtext { get; set; }
        public Color ItemColor { get; set; }


        public SidebarItemModel(string itemName, string subtext, Color itemColor)
        {
            ItemName = itemName;
            Subtext = subtext;
            ItemColor = itemColor;
        }
    }
}
