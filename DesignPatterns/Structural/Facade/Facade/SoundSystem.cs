namespace Facade;

public class SoundSystem
{
    public void On()
    {
        Console.WriteLine("Sound system is On");
    }

    public void Off()
    {
        Console.WriteLine("Sound system is Off");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine("Sound system volume is set to " + volume);
    }
}
