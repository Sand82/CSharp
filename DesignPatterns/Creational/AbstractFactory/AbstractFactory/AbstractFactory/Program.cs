using AbstractFactory;
using AbstractFactory.IndoorActivities;
using AbstractFactory.OutdoorActivities;

IFactory factory;

Console.WriteLine("Choose type of activity - 'Outdoor' or 'Indoor' !");

while (true)
{
    var factoryType = Console.ReadLine();

    if (factoryType?.ToLower() == "outdoor")
    {
        factory = new OutdoorFactory();
    }
    else if (factoryType?.ToLower() == "indoor")
    {
        factory = new IndoorFactory();
    }
    else
    {
        Console.WriteLine("Games end");
        break;
    }

    var game = factory.CreateIGame();
    var sport = factory.CreateISport();

    game.Play();
    sport.Play();
}