namespace Strategy;

public class PaymentService
{
    private IPaymentStrategy paymentStrategy;

    public PaymentService(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void SetStrategy(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        paymentStrategy.Pay(amount);
    }
}
