namespace Chain_of_responsibility.Scheme.Abstraction;

public interface IHandler
{
    IHandler Successor { get; set; }
    void HandleRequest(int condition);
}