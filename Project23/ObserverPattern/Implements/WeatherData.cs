using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implements
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private float _temp;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach(var oberver in _observers)
            {
                oberver.Update(_temp,_humidity,_pressure);
            }
        }

        public void SetMeasurements(float temp, float hum, float pressure)
        {
            _humidity = hum;
            _temp = temp;
            _pressure = pressure;
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}