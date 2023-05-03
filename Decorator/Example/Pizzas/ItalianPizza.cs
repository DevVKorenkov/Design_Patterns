using Decorator.Example.Pizzas.Abstration;

namespace Decorator.Example.Pizzas;

public class ItalianPizza : Pizza
{
    public ItalianPizza() : base("Italian pizza")
    {
    }

    public override int GetCost()
    {
        return 10;
    }
}
