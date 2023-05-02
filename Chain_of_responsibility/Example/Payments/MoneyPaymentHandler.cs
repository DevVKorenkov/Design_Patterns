using Chain_of_responsibility.Example.Payments.Abstraction;

namespace Chain_of_responsibility.Example.Payments;

public class MoneyPaymentHandler : IPaymentHandler
{
    public IPaymentHandler Successor { get; set; }
    public void Handler(Receiver receiver)
    {
        if (receiver.MoneyTransfer)
        {
            Console.WriteLine("Money transfer system is used");
        }
        else if (Successor != null)
        {
            Successor.Handler(receiver);
        }
    }
}