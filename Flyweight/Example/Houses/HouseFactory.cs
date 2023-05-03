using Flyweight.Example.Houses.Abstraction;

namespace Flyweight.Example.Houses;

public class HouseFactory
{
    private Dictionary<string, IHouse> _houses = new Dictionary<string, IHouse>();

    public HouseFactory()
    {
        _houses.Add("Concrete", new ConcreteHouse(10));
        _houses.Add("Brick", new ConcreteHouse(5));
    }

    public IHouse GetHouse(string key)
    {
        return _houses.TryGetValue(key, out var house) ? house : null;
    }
}