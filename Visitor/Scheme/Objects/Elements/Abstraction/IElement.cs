using Visitor.Scheme.Visitors.Abstraction;

namespace Visitor.Scheme.Objects.Elements.Abstraction;

/// <summary>
/// Element's interface defines Accept method which takes a visitor as a parameter.  
/// </summary>
public interface IElement
{
    string SomeState { get; set; }
    void Accept(IVisitor visitor);
}