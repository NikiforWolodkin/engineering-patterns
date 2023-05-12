namespace Lab6Lib
{
    public class Publisher
    {
        private delegate void EventRaisedHandler(string eventName);
        private event EventRaisedHandler _eventRaised;
        private string _eventName;
            
        public Publisher(string eventName)
        {
            _eventName = eventName;        
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _eventRaised += subscriber.Update;
        }

        public bool Unsubscribe (ISubscriber subscriber)
        {
            _eventRaised -= subscriber.Update;

            return true;
        }

        public int Notify()
        {
            EventRaisedHandler handler = _eventRaised;

            if (handler is not null)
            {
                handler(_eventName);

                return _eventRaised.GetInvocationList().Count();
            }

            return 0;
        }
    }
}
