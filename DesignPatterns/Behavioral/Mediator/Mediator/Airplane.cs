namespace Mediator;

public class Airplane
{
    public string? Name { get; }

    private IControlTower controlTower;

    public Airplane(string? name, IControlTower controlTower)
    {
        Name = name;
        this.controlTower = controlTower;
    }

    public void RequestLanding()
    {
        Console.WriteLine($"{Name} request landing.");
        controlTower.RequestToLand(this);
    }

    public void Land()
    {
        Console.WriteLine($"{Name}: Landing...");
    }

    public void Wait()
    {
        Console.WriteLine($"{Name}: Waiting in the air.");
    }
}
