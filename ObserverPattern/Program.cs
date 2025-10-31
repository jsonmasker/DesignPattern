using System;
using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        // Demo showing how to use the subject and observers together
        static void Main(string[] args)
        {
            // Create the subject (the data source)
            var weatherStation = new WeatherStation();

            // Create observers (displays)
            var currentDisplay = new CurrentConditionsDisplay();
            var statisticsDisplay = new StatisticsDisplay();
            var forecastDisplay = new ForecastDisplay();

            // Register observers with the subject so they receive updates
            weatherStation.RegisterObserver(currentDisplay);
            weatherStation.RegisterObserver(statisticsDisplay);
            weatherStation.RegisterObserver(forecastDisplay);

            // Simulate new weather measurements; observers are notified automatically
            Console.WriteLine("First measurement:");
            weatherStation.SetMeasurements(80, 65, 30.4f);

            Console.WriteLine("\nSecond measurement:");
            weatherStation.SetMeasurements(82, 70, 29.2f);

            Console.WriteLine("\nThird measurement:");
            weatherStation.SetMeasurements(78, 90, 29.2f);

            // Show that observers can be removed at runtime
            Console.WriteLine("\nRemove forecast display and update:");
            weatherStation.RemoveObserver(forecastDisplay);
            weatherStation.SetMeasurements(62, 90, 28.1f);

            Console.WriteLine("\nDemo complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
