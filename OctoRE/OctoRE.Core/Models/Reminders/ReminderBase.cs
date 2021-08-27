namespace OctoRE.Core.Models
{
    public class ReminderBase : REObject
    {
        private readonly int _interval;
        private int _elapsed;

        public ReminderBase(int interval)
        {
            _interval = interval;
        }

        public void Update()
        {
            _elapsed++;
            if (_elapsed > _interval)
            {
                Remind();
            }
        }

        public void Remind()
        {
            _elapsed = 0;
        }
    }
}
