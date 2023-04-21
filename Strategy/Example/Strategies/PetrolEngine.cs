using Strategy.Example.Strategies.Abstraction;

namespace Strategy.Example.Strategies;

public class PetrolEngine : IEngine
{
    public void Move()
    {
        Console.WriteLine("Car is moving by petrol");
    }
}