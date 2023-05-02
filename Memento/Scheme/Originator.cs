namespace Memento.Scheme;

/// <summary>
/// Makes a memento object for save its, Originator's, state
/// </summary>
public class Originator
{
    public string State { get; set; }

    public void SetMemento(Memento memento)
    {
        State = memento.State;
    }

    public Memento CreateMemento()
    {
        return new Memento(State);
    }
}