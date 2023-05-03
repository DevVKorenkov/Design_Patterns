namespace Composite.Scheme;

/// <summary>
/// Presents a component which has an ability to contain other components
/// and implements functions to add and remove components
/// </summary>
public class Composite : IComponent
{
    public string Name { get; }

    private List<IComponent> _children;

    public Composite(string name)
    {
        _children = new List<IComponent>();
        Name = name;
    }
    
    public void Display()
    {
        Console.WriteLine(Name);

        foreach (var c in _children)
        {
            Console.WriteLine(c.Name);
        }
    }

    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IComponent component)
    {
        _children.Remove(component);
    }
}