using Strategy.Example.Strategies.Abstraction;

namespace Strategy.Example.Strategies;

public class ElectricEngine : IEngine
{
    public void Move()
    {
        Console.WriteLine("Car is moving by electricity");
    }
}