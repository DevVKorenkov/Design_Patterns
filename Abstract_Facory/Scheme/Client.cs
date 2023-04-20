using Abstract_Facory.Scheme.Factories.Abstract;
using Abstract_Facory.Scheme.Products.Abstract;

namespace Abstract_Facory.Scheme;

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
