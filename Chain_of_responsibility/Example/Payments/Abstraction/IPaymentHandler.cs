namespace Chain_of_responsibility.Example.Payments.Abstraction;

public interface IPaymentHandler
{
    IPaymentHandler Successor { get; set; }
    void Handler(Receiver receiver);
}