namespace Strategy;

public class BankTransferPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay amount {amount} with Bank Transfer.");
    }
}
