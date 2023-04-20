using Builder.Scheme.Builders.Abstract;
using Builder.Scheme.Products;

namespace Builder.Scheme.Builders;

public class SpecificBuilder : IBuilder
{
    Product product = new Product();
    public void BuildPartA()
    {
        product.Add("part a");
    }

    public void BuildPartB()
    {
        product.Add("part b");
    }

    public void BuildPartC()
    {
        product.Add("part c");
    }

    public Product GetResult()
    {
        return product;
    }
}
