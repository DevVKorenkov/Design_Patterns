namespace Memento.Scheme;

/// <summary>
///  Stores the state of Originator object
///  and allow the main access only this Originator object
/// </summary>
public class Memento
{
    public string State { get; private set; }

    public Memento(string state)
    {
        State = state;
    }
}