using Factory_Method.Example.Creators.Abstraction;
using Factory_Method.Example.Products;
using Factory_Method.Example.Products.Abstraction;

namespace Factory_Method.Example.Creators;

/// <summary>
/// As a certain creator
/// </summary>
public class ConcreteHouseDeveloper : Developer
{
    public ConcreteHouseDeveloper(string name) : base(name)
    {
    }

    public override House Create(int floorCount)
    {
        return new ConcreteHouse(floorCount);
    }
}
