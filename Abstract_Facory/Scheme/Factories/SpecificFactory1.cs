using Abstract_Factory.Scheme.Factories.Abstract;
using Abstract_Factory.Scheme.Products;
using Abstract_Factory.Scheme.Products.Abstract;

namespace Abstract_Factory.Scheme.Factories;

public class SpecificFactory1 : Factory
{
    public override ProductA CreateProductA()
    {
        return new SpecificProductA1();
    }

    public override ProductB CreateProductB()
    {
        return new SpecificProductB1();
    }
}
