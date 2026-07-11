using Strategy;
var paymentService = new PaymentService(new CreditCardPayment());

paymentService.ProcessPayment(100);

paymentService.SetStrategy(new PayPalPayment());
paymentService.ProcessPayment(250);

paymentService.SetStrategy(new BankTransferPayment());
paymentService.ProcessPayment(500);