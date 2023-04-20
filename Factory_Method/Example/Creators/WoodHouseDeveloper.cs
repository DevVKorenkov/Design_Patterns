using Factory_Method.Example.Creators.Abstraction;
using Factory_Method.Example.Products;
using Factory_Method.Example.Products.Abstraction;

namespace Factory_Method.Example.Creators;

public class WoodHouseDeveloper : Developer
{
    public WoodHouseDeveloper(string name) : base(name)
    {
    }

    public override House Create(int floorCount)
    {
        return new WoodHouse(floorCount);
    }
}
