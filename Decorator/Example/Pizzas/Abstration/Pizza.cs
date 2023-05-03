namespace Decorator.Example.Pizzas.Abstration;

/// <summary>
/// As an abstract component
/// </summary>
public abstract class Pizza
{
    public string Name { get; private set; }

    public Pizza(string name)
    {
        Name = name;
    }

    public abstract int GetCost();
}
