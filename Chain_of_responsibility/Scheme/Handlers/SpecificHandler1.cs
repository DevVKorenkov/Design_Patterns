using Chain_of_responsibility.Scheme.Abstraction;

namespace Chain_of_responsibility.Scheme.Handlers;

public class SpecificHandler1 : IHandler
{
    public IHandler Successor { get; set; }
    public void HandleRequest(int condition)
    {
        // Some request treatment
        
        if (condition == 1)
        {
            // End of the request
        }
        else if (Successor != null)
        {
            Successor.HandleRequest(condition);
        }
    }
}