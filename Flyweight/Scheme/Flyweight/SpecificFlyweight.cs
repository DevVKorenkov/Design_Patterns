namespace Flyweight.Scheme.Flyweight;

/// <summary>
/// A certain separated Flyweight  implementation.
/// If necessary, it adds an internal state. Also this state should be independent of a context.
/// </summary>
public class SpecificFlyweight : Abstraction.Flyweight
{
    private int intrinsicState;
    
    public override void Operation(int extrinsicState)
    {
        
    }
}