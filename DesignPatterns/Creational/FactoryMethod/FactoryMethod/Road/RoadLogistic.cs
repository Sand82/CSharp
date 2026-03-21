namespace FactoryMethod.Road;

public class RoadLogistic : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}
