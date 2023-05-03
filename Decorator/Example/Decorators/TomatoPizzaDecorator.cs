using Decorator.Example.Decorators.Abstraction;
using Decorator.Example.Pizzas.Abstration;

namespace Decorator.Example.Decorators;

public class TomatoPizzaDecorator : PizzaDecorator
{
    public TomatoPizzaDecorator(Pizza pizza) 
        : base(pizza.Name + " with tomatoes", pizza)
    {
    }

    public override int GetCost()
    {
        return pizza.GetCost() + 3;
    }
}
