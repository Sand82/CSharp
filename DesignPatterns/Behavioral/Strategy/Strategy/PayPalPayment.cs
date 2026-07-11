namespace Strategy;

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay amount {amount} with PayPal.");
    }
}
