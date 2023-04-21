using Strategy.Scheme.Strategies.Abstractions;

namespace Strategy.Scheme;

public class Context
{
    public IStrategy ContextStrategy { get; set; }

    public Context(IStrategy strategy)
    {
        ContextStrategy = strategy;
    }

    public void ExecuteAlgorithm()
    {
        ContextStrategy.Algorithm();
    }
}