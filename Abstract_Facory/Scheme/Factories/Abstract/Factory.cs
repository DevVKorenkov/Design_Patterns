using Abstract_Factory.Scheme.Products.Abstract;

namespace Abstract_Factory.Scheme.Factories.Abstract;

public abstract class Factory
{
    public abstract ProductA CreateProductA();
    public abstract ProductB CreateProductB();
}
