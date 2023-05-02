using Visitor.Example.Accounts;

namespace Visitor.Example.Visitors.Abstraction;

/// <summary>
/// Like a visitor
/// </summary>
public interface IVisitor
{
    void VisitPersonAccount(Person personAcc);
    void VisitCompanyAccount(Company companyAcc);
}