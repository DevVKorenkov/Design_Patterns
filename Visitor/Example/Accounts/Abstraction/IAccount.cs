using Visitor.Example.Visitors.Abstraction;

namespace Visitor.Example.Accounts.Abstraction;

/// <summary>
/// Like IElement
/// </summary>
public interface IAccount
{
    void Accept(IVisitor visitor);
}