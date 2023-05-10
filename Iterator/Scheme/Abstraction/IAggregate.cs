namespace Iterator.Scheme.Abstraction;

/// <summary>
/// Defines the interface for creation of the iterator-object.
/// </summary>
public interface IAggregate
{
    Object this[int index] { get; set; }
    int Count { get; protected set; }
    IIterator CreateIterator();
}