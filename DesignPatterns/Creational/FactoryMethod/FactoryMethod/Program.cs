using FactoryMethod;
using FactoryMethod.Air;
using FactoryMethod.Road;
using FactoryMethod.Sea;

Logistics logistics;

Console.WriteLine("Choose logistic Air/Road/Sea");

while (true)
{
    var input = Console.ReadLine();

    if (input?.ToLower() == "air") 
    {
        logistics = new AirLogistic();
    }
    else if (input?.ToLower() == "road")
    {
        logistics = new RoadLogistic();
    }
    else if (input?.ToLower() == "sea") 
    { 
        logistics = new SeaLogistic();
    }
    else
    {
        break;
    }

    logistics.PlanDelivery();
}
