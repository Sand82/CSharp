namespace Bridge;

public class Radio : IDevice
{
    private bool on = false;
    private int volume = 30;

    public bool IsEnabled()
    {
        return on;
    }

    public void Enable()
    {
        on = true;
        Console.WriteLine("Radio is ON");
    }

    public void Disable()
    {
        on = false;
        Console.WriteLine("Radio is OFF");
    }
    
    public int GetVolume()
    {
        return volume;
    }    

    public void SetVolume(int percent)
    {
        volume = percent;
        Console.WriteLine($"Radio Volume set to {volume}");
    }
}
