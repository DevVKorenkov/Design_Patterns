namespace Composite.Example.Abstraction;

public abstract class Component : IItem
{
    public string Name { get; }

    public Component(string name)
    {
        Name = name;
    }

    public virtual void Print()
    {
        Console.WriteLine(Name);
    }

    public virtual void Add(Component component)
    {
        
    }

    public virtual void Remove(Component component)
    {
        
    }
   
}