# Observer Pattern — Tutorial

This project demonstrates the Observer design pattern using a simple weather-station example.

## Overview

The Observer pattern defines a one-to-many dependency between objects so that when one object (the subject) changes state, all its dependents (observers) are notified and updated automatically.

This demo implements the pattern with a `WeatherStation` subject and several display observers:

- `IObserver` — observer interface that receives updates (`Update(float temperature, float humidity, float pressure)`).
- `ISubject` — subject interface to register/unregister observers and notify them.
- `WeatherStation` — concrete subject that holds the weather data and notifies observers when measurements change.
- `CurrentConditionsDisplay` — observer that prints the latest temperature and humidity.
- `StatisticsDisplay` — observer that computes and prints average/max/min temperature.
- `ForecastDisplay` — observer that prints a simple forecast based on pressure changes.

Files are organized under the `ObserverPattern` project:

- `Program.cs` — demo `Main` that wires subject and observers and simulates updates.
- `IObserver.cs`, `ISubject.cs` — interfaces.
- `WeatherStation.cs` — concrete subject implementation.
- `Displays/CurrentConditionsDisplay.cs`, `Displays/StatisticsDisplay.cs`, `Displays/ForecastDisplay.cs` — observer implementations.

## How it works (brief)

1. Observers implement `IObserver` and provide `Update(...)` to react to state changes.
2. The `WeatherStation` implements `ISubject`, keeps a list of `IObserver` instances, and calls `NotifyObservers()` whenever `SetMeasurements(...)` is invoked.
3. Observers register with the subject using `RegisterObserver(...)` and can be removed via `RemoveObserver(...)`.
4. In `Program.Main` the demo registers three displays, triggers several measurement updates, then removes the forecast display and updates again to show dynamic registration/unregistration.

## Run the demo

1. Open the `ObserverPattern` project in your IDE or terminal.
2. Build and run the project (example with .NET CLI):

   - `dotnet build` from the solution root
   - `dotnet run --project ObserverPattern/ObserverPattern.csproj`

3. Observe the console output showing notifications received by each display.

## Notes and variations

- The example uses explicit `IObserver`/`ISubject` interfaces. In production C# code you might prefer using events/delegates to decouple publisher and subscribers.
- Each display is placed in the `Displays` folder to keep concerns separated; you can further split classes into separate namespaces if desired.

---

This README gives a quick tour of the example. For questions or changes (event-based version, unit tests, or Razor Pages UI demonstration), update the project or ask for help.
