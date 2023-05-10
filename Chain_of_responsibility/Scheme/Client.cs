using Chain_of_responsibility.Scheme.Abstraction;
using Chain_of_responsibility.Scheme.Handlers;

namespace Chain_of_responsibility.Scheme;

/// <summary>
/// Sends the request to the handler object
/// </summary>
public class Client
{
    void MakeRequest()
    {
        IHandler handler1 = new SpecificHandler1();
        IHandler handler2 = new SpecificHandler2();

        handler1.Successor = handler2;
        handler1.HandleRequest(2);
    }
}