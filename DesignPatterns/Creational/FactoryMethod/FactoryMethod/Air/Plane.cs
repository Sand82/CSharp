namespace FactoryMethod.Air;

public class Plane : ITransport
{
    public void Delivery()
    {
        Console.WriteLine("Delivery goods by air using a Plane.");
    }
}
