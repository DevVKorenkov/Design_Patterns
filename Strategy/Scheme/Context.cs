using Strategy.Scheme.Strategies.Abstractions;

namespace Strategy.Scheme;

/// <summary>
/// Keeps the reference to an abstract strategy object
/// and has an aggregate relationship with IStrategy
/// </summary>
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