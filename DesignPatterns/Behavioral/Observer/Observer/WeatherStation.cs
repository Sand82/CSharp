namespace Observer;

public class WeatherStation : ISubject
{
    private readonly List<IObserver> observers = new();
    private int temperature;

    public void SetTemperature(int temperature)
    {
        this.temperature = temperature;
        Console.WriteLine($"Weather Station: Temperature changed to {temperature}°C");

        Notify();
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }
}
