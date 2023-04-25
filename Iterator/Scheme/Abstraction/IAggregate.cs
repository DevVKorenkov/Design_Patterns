namespace Iterator.Scheme.Abstraction;

public interface IAggregate
{
    Object this[int index] { get; set; }
    int Count { get; protected set; }
    IIterator CreateIterator();
}