using Decorator.Example.Decorators;
using Decorator.Example.Pizzas;
using Decorator.Example.Pizzas.Abstration;

public class Program
{
    public static void Main()
    {
        Pizza italianPizza = new ItalianPizza();
        italianPizza = new TomatoPizzaDecorator(italianPizza);

        Console.WriteLine($"The name: {italianPizza.Name}, the cost: {italianPizza.GetCost()}");

        Pizza italianPizza1 = new ItalianPizza();
        italianPizza1 = new ExtraCheesePizzaDecorator(italianPizza1);

        Console.WriteLine($"The name: {italianPizza1.Name}, the cost: {italianPizza1.GetCost()}");

        Pizza bulgarianPizza = new BulgarianPizza();
        bulgarianPizza = new ExtraCheesePizzaDecorator(bulgarianPizza);

        Console.WriteLine($"The name: {bulgarianPizza.Name}, the cost: {bulgarianPizza.GetCost()}");

        Console.ReadKey();

    }
}