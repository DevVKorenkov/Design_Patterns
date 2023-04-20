using Factory_Method.Example.Products.Abstraction;

namespace Factory_Method.Example.Products;

public class WoodHouse : House
{
    public WoodHouse(int floorCount) : base(floorCount)
    {
    }
}
