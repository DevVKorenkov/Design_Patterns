using Visitor.Scheme.Objects.Elements.Abstraction;
using Visitor.Scheme.Visitors.Abstraction;

namespace Visitor.Scheme.Objects;

/// <summary>
/// Some structure which stores IElement objects and provides the access to them.
/// </summary>
public class ObjectStructure
{
    private List<IElement> _elements = new List<IElement>();

    public void Add(IElement element)
    {
        _elements.Add(element);
    }

    public void Remove(IElement element)
    {
        _elements.Remove(element);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var e in _elements)
        {
            e.Accept(visitor);
        }
    }
}