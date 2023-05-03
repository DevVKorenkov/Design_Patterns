namespace Flyweight.Scheme.Flyweight.Abstraction;

/// <summary>
/// Defines the interface which helps flyweights objects get an outside state or affect the state  
/// </summary>
public abstract class Flyweight
{
    public abstract void Operation(int extrinsicState);
}