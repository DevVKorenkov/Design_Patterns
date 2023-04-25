using Iterator.Scheme.Abstraction;

namespace Iterator.Scheme;

public class Client
{
    public void Iterate()
    {
        IAggregate aggregate = new SpecificAggregate();
        IIterator iterator = aggregate.CreateIterator();

        object item = iterator.First();
        while (!iterator.IsDone())
        {
            item = iterator.Next();
        }
    }
}