namespace Test.Patterns.Temp
{
   public class TemperatureSensor : ISubject
   {
        private List<IObserver> _observers = new List<IObserver>();
        private double _temperature;

        public double Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }
        }
   }
}