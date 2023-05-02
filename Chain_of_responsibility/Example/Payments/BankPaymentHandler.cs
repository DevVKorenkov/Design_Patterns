using Chain_of_responsibility.Example.Payments.Abstraction;

namespace Chain_of_responsibility.Example.Payments;

public class BankPaymentHandler : IPaymentHandler
{
    public IPaymentHandler Successor { get; set; }
    public void Handler(Receiver receiver)
    {
        if (receiver.BankTransfer)
        {
            Console.WriteLine("Bank transfer is used");
        }
        else if (Successor != null)
        {
            Successor.Handler(receiver);
        }
    }
}