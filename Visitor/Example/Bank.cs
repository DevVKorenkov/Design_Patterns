using Visitor.Example.Accounts.Abstraction;
using Visitor.Example.Visitors.Abstraction;

namespace Visitor.Example;

/// <summary>
/// As a structure
/// </summary>
public class Bank
{
    private List<IAccount> _accounts = new List<IAccount>();

    public void Add(IAccount account)
    {
        _accounts.Add(account);
    }

    public void Remove(IAccount account)
    {
        _accounts.Remove(account);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var a in _accounts)
        {
            a.Accept(visitor);
        }
    }
}