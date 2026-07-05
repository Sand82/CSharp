namespace Observer;

public class PhoneDisplay : IObserver
{
    public void Update(int temperature)
    {
        Console.WriteLine($"Phone Display: Current temperature is {temperature}°C");
    }
}
