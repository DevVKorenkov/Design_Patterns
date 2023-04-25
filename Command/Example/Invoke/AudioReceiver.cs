using Command.Example.Invoke.Abstraction;

namespace Command.Example.Invoke;

public class AudioReceiver : IInvoke
{
    public void PositiveAction()
    {
        Console.WriteLine("Audio receiver is on");
    }

    public void NegativeAction()
    {
        Console.WriteLine("Audio receiver is off");
    }
}