using System;

namespace ObserverPattern.Displays
{
    // Concrete observer that computes simple statistics (avg, max, min)
    public class StatisticsDisplay : IObserver
    {
        private float maxTemp = float.MinValue;
        private float minTemp = float.MaxValue;
        private float tempSum = 0;
        private int numReadings = 0;

        // Accumulate stats each time an update arrives
        public void Update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings++;
            if (temperature > maxTemp) maxTemp = temperature;
            if (temperature < minTemp) minTemp = temperature;
            Display();
        }

        // Display the computed statistics
        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {tempSum / numReadings:F1}/{maxTemp}/{minTemp}");
        }
    }
}
