using Factory_Method.Example.Products.Abstraction;

namespace Factory_Method.Example.Products;

/// <summary>
/// As a certain product
/// </summary>
public class ConcreteHouse : House
{
    public ConcreteHouse(int floorCount) : base(floorCount)
    {
        
    }
}
