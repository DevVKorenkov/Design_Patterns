using Interface_Segregation_Principle.Right.TooBigInterfacesResolve.Abstraction;

namespace Interface_Segregation_Principle.Right.TooBigInterfacesResolve.Clients;

public class EmailMessage : IEmailMessage
{
    public string To { get; set; }
    public string From { get; set; }
    public string Text { get; set; }
    public string Subject { get; set; }
    public void Send() => Console.WriteLine($"Send email message: {Text}");
}