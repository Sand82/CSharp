namespace FactoryMethod.Air;

public class AirLogistic : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Plane();
    }
}
