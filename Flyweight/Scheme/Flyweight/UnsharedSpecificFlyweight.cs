namespace Flyweight.Scheme.Flyweight;

/// <summary>
///  A certain implementation of a Flyweight but this kind of object is unseparated.
/// </summary>
public class UnsharedSpecificFlyweight : Abstraction.Flyweight
{
    private int _allStates;
    
    public override void Operation(int extrinsicState)
    {
        _allStates = extrinsicState;
    }
}