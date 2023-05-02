using Factory_Method.Scheme.Creators.Abstraction;
using Factory_Method.Scheme.Products;
using Factory_Method.Scheme.Products.Abstraction;

namespace Factory_Method.Scheme.Creators;

/// <summary>
/// Certain product creator
/// </summary>
public class ProductACreator : Creator
{
    public override Product FactoryMethod()
    {
        return new ProductA();
    }
}
