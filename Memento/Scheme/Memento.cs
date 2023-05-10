namespace Memento.Scheme;

/// <summary>
/// Stores the state of the Originator object
/// and allows the main access only to this Originator object.
/// </summary>
public class Memento
{
    public string State { get; private set; }

    public Memento(string state)
    {
        State = state;
    }
}