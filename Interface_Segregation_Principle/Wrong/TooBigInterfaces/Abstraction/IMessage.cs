namespace Interface_Segregation_Principle.Wrong.TooBigInterfaces.Abstraction;

public interface IMessage
{
    void Send();
    public string Text { get; set; }
    public string Subject { get; set; }
    public string To { get; set; }
    public string From { get; set; }

    public byte[] Voice { get; set; }
}