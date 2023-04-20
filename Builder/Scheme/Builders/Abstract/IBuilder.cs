using Builder.Scheme.Products;

namespace Builder.Scheme.Builders.Abstract;

public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    Product GetResult();
}
