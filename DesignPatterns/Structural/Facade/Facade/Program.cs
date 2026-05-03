using Facade;

var player = new DVDPlayer();
var protector = new Protector();
var soundSystem = new SoundSystem();

var theater = new HomeTheaterFacade(player, protector, soundSystem);

while (true)
{
    Console.WriteLine("What movie do you want to watch?");

    var movie = Console.ReadLine()!;
    theater.WatchMovie(movie);

    await Delay(5000);

    Console.WriteLine("do you want to turn off home theater: Yes/ No");

    var input = Console.ReadLine();

    if (input?.ToLower() == "yes")
    {
        break;
    }    
}

theater.EndMovie();

async Task Delay(int interval)
{
    await Task.Delay(interval);
}