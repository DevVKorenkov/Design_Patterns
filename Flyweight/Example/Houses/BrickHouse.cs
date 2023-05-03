using Flyweight.Example.Houses.Abstraction;

namespace Flyweight.Example.Houses;

public class BrickHouse : IHouse
{
    public int Floors { get; }

    public BrickHouse(int floorsCount)
    {
        Floors = floorsCount;
    }
    
    public void Build(double longitude, double latitude)
    {
        Console.WriteLine($"Brick house was built with {Floors} floors. Place is {latitude}, {longitude}");
    }
}