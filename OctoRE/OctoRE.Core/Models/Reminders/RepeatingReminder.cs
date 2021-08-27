namespace OctoRE.Core.Models
{
    public class RepeatingReminder : ReminderBase
    {
        public string ItemName;
        public RepeatingReminder(int interval, string itemName) : base(interval)
        {
            ItemName = itemName;
        }
    }
}
