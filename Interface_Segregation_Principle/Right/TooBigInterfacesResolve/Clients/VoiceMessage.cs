using Interface_Segregation_Principle.Right.TooBigInterfacesResolve.Abstraction;

namespace Interface_Segregation_Principle.Right.TooBigInterfacesResolve.Clients;

public class VoiceMessage : IVoiceMessage
{
    public string To { get; set; }
    public string From { get; set; }
    public byte[] Voice { get; set; }
    public void Send() => Console.WriteLine($"Send voice message");
}