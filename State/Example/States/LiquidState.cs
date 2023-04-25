using State.Example.States.Abstraction;

namespace State.Example.States;

public class LiquidState : IWaterState
{
    public void Heat(Water water)
    {
        Console.WriteLine("Liquid water was transformed to the water steam");
        water.State = new GasState();
    }

    public void Cold(Water water)
    {
        Console.WriteLine("Liquid water was transformed to the ice");
        water.State = new SolidSate();
    }
}