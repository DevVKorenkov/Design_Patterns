using Visitor.Example.Accounts.Abstraction;
using Visitor.Example.Visitors.Abstraction;

namespace Visitor.Example.Accounts;

public class Company : IAccount
{
    public string Name { get; set; }
    public string RegNumber { get; set; }
    public string Number { get; set; }
    
    public void Accept(IVisitor visitor)
    {
        visitor.VisitCompanyAccount(this);
    }
}