namespace Chain_of_responsibility.Scheme.Abstraction;

/// <summary>
/// Defines the interface for processing a request. Also it can define a reference to the next handler.
/// </summary>
public interface IHandler
{
    IHandler Successor { get; set; }
    void HandleRequest(int condition);
}