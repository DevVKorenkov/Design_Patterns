using Visitor.Scheme.Objects.Elements.Abstraction;
using Visitor.Scheme.Visitors.Abstraction;

namespace Visitor.Scheme.Objects.Elements;

/// <summary>
/// certain element which implements Accept method
/// </summary>
public class ElementB : IElement
{
    public string SomeState { get; set; }
    public void Accept(IVisitor visitor)
    {
        visitor.VisitElementB(this);
    }

    public void OperationB()
    {
        
    }
}