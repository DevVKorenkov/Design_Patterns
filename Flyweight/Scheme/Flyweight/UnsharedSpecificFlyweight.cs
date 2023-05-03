namespace Flyweight.Scheme.Flyweight;

public class UnsharedSpecificFlyweight : Abstraction.Flyweight
{
    private int _allStates;
    
    public override void Operation(int extrinsicState)
    {
        _allStates = extrinsicState;
    }
}