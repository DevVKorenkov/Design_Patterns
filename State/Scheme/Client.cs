using State.Scheme.States;

namespace State.Scheme;

public class Client
{
    public void ChangeState()
    {
        var context = new Context(new StateA());
        
        context.Request(); // Change current state to state B 
        context.Request(); // Change current state to state A
    }
}