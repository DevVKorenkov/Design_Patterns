using Abstract_Factory.Scheme.Factories.Abstract;
using Abstract_Factory.Scheme.Products.Abstract;

namespace Abstract_Factory.Scheme;

public class Client
{
    private ProductA _productA;
    private ProductB _productB;

    public Client(Factory factory)
    {
        _productA = factory.CreateProductA();
        _productB = factory.CreateProductB();
    }

    public void Run() { }
}
