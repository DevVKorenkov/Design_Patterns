namespace Iterator.Scheme.Abstraction;

public interface IIterator
{
    object First();
    object Next();
    bool IsDone();
    object CurrentItem();
}