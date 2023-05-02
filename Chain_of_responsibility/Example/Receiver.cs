namespace Chain_of_responsibility.Example;

public class Receiver
{
    public bool BankTransfer { get; set; }
    public bool MoneyTransfer { get; set; }
    public bool PaypalTransfer { get; set; }

    public Receiver(bool bankTransfer, bool moneyTransfer, bool paypalTransfer)
    {
        BankTransfer = bankTransfer;
        MoneyTransfer = moneyTransfer;
        PaypalTransfer = paypalTransfer;
    }
}