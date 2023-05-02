namespace Memento.Example;

/// <summary>
/// Caretaker
/// </summary>
public class GameHistory
{
    public Stack<HeroMemento> History { get; set; }

    public GameHistory()
    {
        History = new Stack<HeroMemento>();
    }
}