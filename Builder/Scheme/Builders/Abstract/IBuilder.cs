using Builder.Scheme.Products;

namespace Builder.Scheme.Builders.Abstract;

/// <summary>
/// Defines the interface to create different object's parts
/// </summary>
public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    Product GetResult();
}
