namespace _47_GenericDelegateEventHandler
{
    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        public int Temperature { get; }

        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    // Raise Event
                    _temperature = value;
                    OnTemperatureChanged(new TemperatureChangedEventArgs(value));
                }
            }
        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }


    // Subscriber
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine("Alert: " + e.Temperature + ", sender is: " + sender);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            monitor.TemperatureChanged += alert.OnTemperatureChanged;

            monitor.Temperature = 20;
            monitor.Temperature = 40;


        }
    }
}
