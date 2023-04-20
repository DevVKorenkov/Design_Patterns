using Abstract_Facory.Scheme.Factories.Abstract;
using Abstract_Facory.Scheme.Products;
using Abstract_Facory.Scheme.Products.Abstract;

namespace Abstract_Facory.Scheme.Factories;

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
