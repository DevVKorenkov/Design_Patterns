using Chain_of_responsibility.Scheme.Abstraction;

namespace Chain_of_responsibility.Scheme.Handlers;

/// <summary>
/// certain implementation of the abstract handler. Contains specific actions for request processing.
/// </summary>
public class SpecificHandler2 : IHandler
{
    public IHandler Successor { get; set; }
    public void HandleRequest(int condition)
    {
        // Some request treatment
        
        if (condition == 2)
        {
            // End of the request
        }
        else if (Successor != null)
        {
            Successor.HandleRequest(condition);
        }
    }
}