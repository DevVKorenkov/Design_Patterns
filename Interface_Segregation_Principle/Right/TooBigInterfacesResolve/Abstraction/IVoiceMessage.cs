namespace Interface_Segregation_Principle.Right.TooBigInterfacesResolve.Abstraction;

public interface IVoiceMessage : IMessage
{
    public byte[] Voice { get; set; }
}