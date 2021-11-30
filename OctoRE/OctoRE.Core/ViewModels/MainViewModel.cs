using System.Collections.ObjectModel;
using System.Drawing;
using OctoRE.Core.Models;

namespace OctoRE.Core.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<SidebarItemModel> SidebarItems { get; set; }

        public string GearIcon { get; set; }


        public MainViewModel()
        {
            SidebarItems = new ObservableCollection<SidebarItemModel>
            {
                new SidebarItemModel("Reminders", "00:00:00", Color.DeepPink, "alarm-black.png"),
                new SidebarItemModel("ToDos", "00", Color.Aquamarine, "alarm-black.png")
            };

            GearIcon = ResourceManager.GetIconUriPath(RegisteredIcons.GearBlack);
        }
    }
}
