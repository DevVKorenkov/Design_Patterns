using State.Scheme.States.Abstraction;

namespace State.Scheme;

/// <summary>
/// an object, the behaviour of which is changed depending on the object condition.
/// An execution of certain actions is delegated to the state object.
/// </summary>
public class Context
{
    public IState State { get; set; }

    public Context(IState state)
    {
        State = state;
    }

    public void Request()
    {
        State.Handle(this);
    }
}