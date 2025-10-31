using System;

namespace ObserverPattern.Displays
{
    // Concrete observer that gives a simple forecast based on pressure changes
    public class ForecastDisplay : IObserver
    {
        // Keep previous and current pressure to determine trend
        private float lastPressure = 29.92f;
        private float currentPressure;

        public void Update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }

        // Display a textual forecast based on pressure trend
        public void Display()
        {
            Console.Write("Forecast: ");
            if (currentPressure > lastPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (currentPressure == lastPressure)
                Console.WriteLine("More of the same");
            else
                Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}
