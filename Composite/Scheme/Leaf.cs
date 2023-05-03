namespace Composite.Scheme;

/// <summary>
/// Presents a component which can't contain other components 
/// </summary>
public class Leaf : IComponent
{
    public string Name { get; }

    public Leaf(string name)
    {
        Name = name;
    }
    
    public void Display()
    {
        Console.WriteLine(Name);
    }

    public void Add(IComponent component)
    {
        
    }

    public void Remove(IComponent component)
    {
        
    }
}