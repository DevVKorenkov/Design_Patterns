using Interface_Segregation_Principle.Wrong.TooBigInterfaces.Abstraction;

namespace Interface_Segregation_Principle.Wrong.TooBigInterfaces;

public class SmsMessage : IMessage
{
    public string Text { get; set; }

    public string Subject
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    public string To { get; set; }
    public string From { get; set; }
    public byte[] Voice 
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public void Send() => Console.WriteLine($"Send sms message: {Text}");
}