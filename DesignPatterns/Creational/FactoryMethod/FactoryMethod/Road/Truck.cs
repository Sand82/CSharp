namespace FactoryMethod.Road;

public class Truck : ITransport
{
    public void Delivery()
    {
        Console.WriteLine("Delivery goods by land using a Truck.");
    }
}
