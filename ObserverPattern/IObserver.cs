namespace ObserverPattern
{
    // Observer interface: implemented by any class that wants to receive updates
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
