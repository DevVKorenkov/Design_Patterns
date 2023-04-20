using Factory_Method.Scheme.Products;
using Factory_Method.Scheme.Creators.Abstraction;
using Factory_Method.Scheme.Products.Abstraction;

namespace Factory_Method.Scheme.Creators;

public class ProductBCreator : Creator
{
    public override Product FactoryMethod()
    {
        return new ProductB();
    }
}
