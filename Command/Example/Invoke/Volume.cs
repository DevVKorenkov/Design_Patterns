using Command.Example.Invoke.Abstraction;

namespace Command.Example.Invoke;

public class Volume : IInvoke
{
    public const int OFF = 0;
    public const int HIGH = 100;
    
    private int _currentLevel;

    public Volume()
    {
        _currentLevel = OFF;
    }

    public void PositiveAction()
    {
        if (_currentLevel < HIGH)
        {
            _currentLevel++;
        }

        Console.WriteLine($"The volume level is {_currentLevel}");
    }

    public void NegativeAction()
    {
        if (_currentLevel > OFF)
        {
            _currentLevel--;
        }
        
        Console.WriteLine($"The volume level is {_currentLevel}");
    }
}