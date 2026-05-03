namespace Facade;

public class HomeTheaterFacade
{
    public readonly DVDPlayer player;

    public readonly Protector protector;

    public readonly SoundSystem soundSystem;

    public HomeTheaterFacade(DVDPlayer player, Protector protector, SoundSystem soundSystem)
    {
        this.player = player;
        this.protector = protector;
        this.soundSystem = soundSystem;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Starting movie " + movie);        

        protector.On();
        soundSystem.On();
        player.On();

        soundSystem.SetVolume(20);
        protector.SetWideScreenMode();
        player.Play(movie);        
    }

    public void EndMovie()
    {
        protector.Off();
        soundSystem.Off();
        player.Off();
    }
}
