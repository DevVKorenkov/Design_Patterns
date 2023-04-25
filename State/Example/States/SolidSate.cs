using State.Example.States.Abstraction;

namespace State.Example.States;

public class SolidSate : IWaterState
{
    public void Heat(Water water)
    {
        Console.WriteLine("The ice was transformed to the liquid");
        water.State = new LiquidState();
    }

    public void Cold(Water water)
    {
        Console.WriteLine("Continuing to decrease the ice temperature");
    }
}