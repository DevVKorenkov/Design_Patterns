using Chain_of_responsibility.Example;
using Chain_of_responsibility.Example.Payments;
using Chain_of_responsibility.Example.Payments.Abstraction;

public class Program
{
    public static void Main()
    {
        var receiver = new Receiver(false, false, true);

        IPaymentHandler bankPayment = new BankPaymentHandler();
        IPaymentHandler moneyPayment = new MoneyPaymentHandler();
        IPaymentHandler paypalPayment = new PaypalPaymentHandler();

        bankPayment.Successor = paypalPayment;
        paypalPayment.Successor = moneyPayment;
        
        bankPayment.Handler(receiver);

        Console.ReadKey();
    }
}