using State.Example.States.Abstraction;

namespace State.Example.States;

public class GasState : IWaterState
{
    public void Heat(Water water)
    {
        Console.WriteLine("Increase the temperature of the water steam");
    }

    public void Cold(Water water)
    {
        Console.WriteLine("water steam was transformed to the liquid");
        water.State = new GasState();
    }
}