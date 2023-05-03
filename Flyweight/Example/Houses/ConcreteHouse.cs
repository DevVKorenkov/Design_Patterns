using Flyweight.Example.Houses.Abstraction;

namespace Flyweight.Example.Houses;

public class ConcreteHouse : IHouse
{
    public int Floors { get; }

    public ConcreteHouse(int floorsCount)
    {
        Floors = floorsCount;
    }
    
    public void Build(double longitude, double latitude)
    {
        Console.WriteLine($"Concrete house was built with {Floors} floors. Place is {latitude}, {longitude}");
    }
}