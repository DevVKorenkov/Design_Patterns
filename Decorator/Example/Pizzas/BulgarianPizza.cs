using Decorator.Example.Pizzas.Abstration;

namespace Decorator.Example.Pizzas;

public class BulgarianPizza : Pizza
{
    public BulgarianPizza() : base("Bulgarian pizza")
    {
    }

    public override int GetCost()
    {
        return 8;
    }
}
