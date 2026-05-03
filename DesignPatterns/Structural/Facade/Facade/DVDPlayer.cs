namespace Facade;

public class DVDPlayer
{
    public void On()
    {
        Console.WriteLine("DVD player On");
    }

    public void Off()
    {
        Console.WriteLine("DVD player Off");
    }

    public void Play(string movie)
    {
        Console.WriteLine("DVD player play movie: " + movie);
    }
}
