namespace Interface_Segregation_Principle.Right.TooBigInterfacesResolve.Abstraction;

public interface IEmailMessage : ITextMessage
{
    public string Subject { get; set; }
}