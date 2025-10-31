using System;

namespace ObserverPattern.Displays
{
    // Concrete observer that displays the current conditions.
    public class CurrentConditionsDisplay : IObserver
    {
        private float temperature;
        private float humidity;

        // Called by the subject when measurements change
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        // Render the current conditions to the console
        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }
    }
}
