using Composite.Example.Abstraction;

namespace Composite.Example;

public class Directory : Component
{
    private List<Component> _children;

    public Directory(string name) : base(name)
    {
        _children = new List<Component>();
    }

    public override void Print()
    {
        Console.WriteLine($"Directory {Name}");
        Console.WriteLine("Contains: ");
        foreach (var c in _children)
        {
            c.Print();
        }
    }

    public override void Add(Component component)
    {
        _children.Add(component);
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
    }
}