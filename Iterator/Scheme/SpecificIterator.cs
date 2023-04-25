using Iterator.Scheme.Abstraction;

namespace Iterator.Scheme;

public class SpecificIterator : IIterator
{
    private readonly IAggregate _aggregate;
    private int _current;

    public SpecificIterator(IAggregate aggregate)
    {
        _aggregate = aggregate;
    }

    public object First() => _aggregate[0];

    public object Next()
    {
        object result = null;

        _current++;

        if (_current < _aggregate.Count)
        {
            result = _aggregate[_current];
        }

        return result;
    }

    public object CurrentItem()
    {
        return _aggregate[_current];
    }

    public bool IsDone()
    {
        return _current >= _aggregate.Count;
    }
}