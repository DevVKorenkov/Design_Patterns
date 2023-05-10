namespace Iterator.Scheme.Abstraction;

/// <summary>
/// Defines the interface to detouring objects.
/// </summary>
public interface IIterator
{
    object First();
    object Next();
    bool IsDone();
    object CurrentItem();
}