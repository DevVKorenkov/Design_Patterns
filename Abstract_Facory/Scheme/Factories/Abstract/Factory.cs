using Abstract_Factory.Scheme.Products.Abstract;

namespace Abstract_Factory.Scheme.Factories.Abstract;

/// <summary>
/// Defines methods for creating objects. The methods return abstract objects,
/// not certain implementations 
/// </summary>
public abstract class Factory
{
    public abstract ProductA CreateProductA();
    public abstract ProductB CreateProductB();
}
