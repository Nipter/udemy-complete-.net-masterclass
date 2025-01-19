namespace _46_Events
{
    public delegate void Notify(string message);

    public class EventPublisher
    {
        // The "On" prefix makes it immedietly clear that the method
        // is associated with an event.
        // It signifies that the method is not just a regular method but
        // one that is called when a specific event occurs.
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            // Invoke the event if there are any subscrivers
            OnNotify?.Invoke(message);
        }
    }

    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine("Event received: " + message);
        }
    }

    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureMonitor
    {
        public event TemperatureChangeHandler OnTemperatureChange;

        private int _temperature;

        public int Temperature { 
            get { return _temperature;  }
            set {
                _temperature = value;
                if(_temperature >30)
                {
                    // Raise Event
                    RaiseTemperatureChangedEvent("Temeperature is above threshold: " + Temperature);
                }
            }  
        }

        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnTemperatureChange?.Invoke(message);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine("Alert: " + message);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //EventPublisher publisher = new EventPublisher();
            //EventSubscriber subscriber = new EventSubscriber();
            //publisher.OnNotify += subscriber.OnEventRaised;

            //publisher.RaiseEvent("test");

            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            monitor.OnTemperatureChange += alert.OnTemperatureChanged;

            monitor.Temperature = 20;
            monitor.Temperature = 40;


        }
    }
}
