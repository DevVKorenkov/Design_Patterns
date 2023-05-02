namespace Memento.Example;

public class GameHistory
{
    public Stack<HeroMemento> History { get; set; }

    public GameHistory()
    {
        History = new Stack<HeroMemento>();
    }
}