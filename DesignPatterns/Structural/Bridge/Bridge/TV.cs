namespace Bridge;

public class TV : IDevice
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
        Console.WriteLine("TV is ON");
    }

    public void Disable()
    {
        on = false;
        Console.WriteLine("TV is OFF");
    }       

    public int GetVolume()
    {
        return volume;
    }    

    public void SetVolume(int percent)
    {
       volume = percent;
       Console.WriteLine($"TV Volume set to {volume}");
    }
}
