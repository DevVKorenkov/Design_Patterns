using State.Example;
using State.Example.States;

public class Program
{
    public static void Main()
    {
        var water = new Water(new LiquidState());
        
        water.Cold();
        water.Heat();
        water.Heat();
        water.Heat();
    }
}