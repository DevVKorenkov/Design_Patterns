using Command.Example.Invoke.Abstraction;

namespace Command.Example.Invoke;

// This is a receiver
public class TV : IInvoke
{
    public void PositiveAction()
    {
        Console.WriteLine("TV is on");
    }

    public void NegativeAction()
    {
        Console.WriteLine("TV is off");
    }
}