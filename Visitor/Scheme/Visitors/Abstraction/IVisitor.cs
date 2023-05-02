using Visitor.Scheme.Objects.Elements;

namespace Visitor.Scheme.Visitors.Abstraction;

/// <summary>
/// Visitor's interface which defines Visit method for each element
/// </summary>
public interface IVisitor
{
    void VisitElementA(ElementA elementA);
    void VisitElementB(ElementB elementB);
}