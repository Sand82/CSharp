namespace FactoryMethod.Sea;

public class Ship : ITransport
{
    public void Delivery()
    {
        Console.WriteLine("Delivery goods by see using a Ship.");
    }
}
