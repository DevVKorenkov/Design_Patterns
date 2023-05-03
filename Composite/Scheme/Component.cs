namespace Composite.Scheme;

/// <summary>
/// Defines each component for tree structure
/// </summary>
public interface IComponent
{
    string Name { get; }
    
    void Display();
    void Add(IComponent component);
    void Remove(IComponent component);
}