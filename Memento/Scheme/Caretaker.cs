namespace Memento.Scheme;

/// <summary>
/// Only does save Memento object.
/// This object doesn't have the access and operations for memento. 
/// </summary>
public class Caretaker
{
    public Memento Memento { get; set; }
}