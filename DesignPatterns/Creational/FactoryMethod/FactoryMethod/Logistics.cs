namespace FactoryMethod;

public abstract class Logistics
{
    public abstract ITransport CreateTransport();

    public void PlanDelivery()
    {
        var transport = CreateTransport();

        transport.Delivery();
    }
}
