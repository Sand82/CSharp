namespace Strategy;

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay amount {amount} with Credit Cart.");
    }
}
