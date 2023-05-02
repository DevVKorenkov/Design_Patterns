using Visitor.Example.Accounts;
using Visitor.Example.Visitors.Abstraction;

namespace Visitor.Example.Visitors;

/// <summary>
/// Certain visitor
/// </summary>
public class XmlSerializeVisitor : IVisitor
{
    public void VisitPersonAccount(Person personAcc)
    {
        string result = "<Person><Name>" + personAcc.Name + "</Name>"+
                        "<Number>" + personAcc.Number + "</Number><Person>";
        Console.WriteLine(result);
    }

    public void VisitCompanyAccount(Company companyAcc)
    {
        string result = "<Company><Name>" + companyAcc.Name + "</Name>" + 
                        "<RegNumber>" + companyAcc.RegNumber + "</RegNumber>" + 
                        "<Number>" + companyAcc.Number + "</Number><Company>";
        Console.WriteLine(result);
    }
}