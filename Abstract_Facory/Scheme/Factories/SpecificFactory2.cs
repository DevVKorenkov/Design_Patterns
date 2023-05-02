using Abstract_Factory.Scheme.Factories.Abstract;
using Abstract_Factory.Scheme.Products;
using Abstract_Factory.Scheme.Products.Abstract;

namespace Abstract_Factory.Scheme.Factories;

/// <summary>
/// Implements abstract methods from basic class
/// and defines witch certain objects to use 
/// </summary>
public class SpecificFactory2 : Factory
{
    public override ProductA CreateProductA()
    {
        return new SpecificProductA2();
    }

    public override ProductB CreateProductB()
    {
        return new SpecificProductB2();
    }
}
