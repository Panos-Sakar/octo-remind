namespace OctoRE.Core.State
{
    public class Dispatch
    {
        public static Dispatch _dispatch;
        public Dispatch Start()
        {
            if (_dispatch == null)
            {
                _dispatch = this;
            }

            return _dispatch;
        }

        public static Dispatch GetDispstch()
        {
            return _dispatch;
        }
    }
}
