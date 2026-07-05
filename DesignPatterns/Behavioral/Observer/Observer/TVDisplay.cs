namespace Observer;

public class TVDisplay : IObserver
{
    public void Update(int temperature)
    {
        Console.WriteLine($"TV Display: Current temperature is {temperature}°C");
    }
}
