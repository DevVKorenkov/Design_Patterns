using Decorator.Example.Pizzas.Abstration;

namespace Decorator.Example.Decorators.Abstraction;

/// <summary>
/// As an abstract decorator
/// </summary>
public class PizzaDecorator : Pizza
{
    protected Pizza pizza;

    public PizzaDecorator(string name, Pizza pizza) : base(name)
    {
        this.pizza = pizza;
    }

    public override int GetCost()
    {
        return 10;
    }
}
