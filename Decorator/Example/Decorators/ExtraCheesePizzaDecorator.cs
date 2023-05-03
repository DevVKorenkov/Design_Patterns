using Decorator.Example.Decorators.Abstraction;
using Decorator.Example.Pizzas.Abstration;

namespace Decorator.Example.Decorators;

public class ExtraCheesePizzaDecorator : PizzaDecorator
{
    public ExtraCheesePizzaDecorator(Pizza pizza) 
        : base(pizza.Name + " with extra cheese", pizza)
    {
    }

    public override int GetCost()
    {
        return pizza.GetCost() + 5;
    }
}
