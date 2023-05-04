namespace Interface_Segregation_Principle.Right.TooBigInterfacesResolve.Abstraction;

public interface IMessage
{
    void Send();
    public string To { get; set; }
    public string From { get; set; }
}