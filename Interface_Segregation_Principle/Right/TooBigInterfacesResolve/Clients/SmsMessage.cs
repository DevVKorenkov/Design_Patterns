using Interface_Segregation_Principle.Right.TooBigInterfacesResolve.Abstraction;

namespace Interface_Segregation_Principle.Right.TooBigInterfacesResolve.Clients;

public class SmsMessage : ITextMessage
{
    public string To { get; set; }
    public string From { get; set; }
    public string Text { get; set; }
    public void Send() => Console.WriteLine($"Send sms message: {Text}");
}