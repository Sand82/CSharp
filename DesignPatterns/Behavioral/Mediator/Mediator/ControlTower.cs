using System.Runtime.CompilerServices;

namespace Mediator;

public class ControlTower : IControlTower
{
    private bool runwayOccupied = false;

    public void RequestToLand(Airplane airplane)
    {
        if (runwayOccupied)
        {
            airplane.Wait();
        }
        else
        {
            Console.WriteLine("Control Tower: Runway is free.");
            airplane.Land();

            runwayOccupied = false;
            Console.WriteLine("Control Tower: Runway is available again.");
        }
    }
}
