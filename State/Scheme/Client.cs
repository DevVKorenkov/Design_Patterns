using State.Scheme.States;

namespace State.Scheme;

public class Client
{
    public void ChangeState()
    {
        var context = new Context(new StateA());
        
        context.Requert(); // Change current state to state B 
        context.Requert(); // Change current state to state A
    }
}