namespace Interface_Segregation_Principle.Right.TooBigInterfacesResolve.Abstraction;

public interface ITextMessage : IMessage
{
    public string Text { get; set; }
}