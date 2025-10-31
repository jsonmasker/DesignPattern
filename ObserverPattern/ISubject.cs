namespace ObserverPattern
{
    // Subject interface: allows observers to register/unregister and receive notifications
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
