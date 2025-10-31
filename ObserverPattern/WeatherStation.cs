using System.Collections.Generic;

namespace ObserverPattern
{
    // Concrete subject. Maintains a list of observers and notifies them when
    // its state (temperature, humidity, pressure) changes.
    public class WeatherStation : ISubject
    {
        // List of registered observers
        private readonly List<IObserver> observers = new();

        // The weather data the subject holds
        private float temperature;
        private float humidity;
        private float pressure;

        // Register a new observer
        public void RegisterObserver(IObserver o) => observers.Add(o);

        // Remove an existing observer
        public void RemoveObserver(IObserver o) => observers.Remove(o);

        // Notify all registered observers with the latest measurements
        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(temperature, humidity, pressure);
            }
        }

        // Update the subject's measurements and immediately notify observers.
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }
    }
}
