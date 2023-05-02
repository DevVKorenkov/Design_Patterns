using Factory_Method.Scheme.Products.Abstraction;

namespace Factory_Method.Scheme.Creators.Abstraction;

/// <summary>
/// Defines an abstract factory method which returns a new Product object
/// </summary>
public abstract class Creator
{
    public abstract Product FactoryMethod();
}
