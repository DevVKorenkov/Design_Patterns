using Visitor.Example.Accounts;
using Visitor.Example.Visitors.Abstraction;

namespace Visitor.Example.Visitors;

/// <summary>
/// Certain visitor
/// </summary>
public class HtmlSerializeVisitor : IVisitor
{
    public void VisitPersonAccount(Person personAcc)
    {
        var result = "<table><tr><td>Property<td><td>Value</td></tr>";
        result += "<tr><td>Name<td><td>" + personAcc.Name + "</td></tr>";
        result += "<tr><td>Number<td><td>" + personAcc.Number + "</td></tr></table>";
        Console.WriteLine(result);
    }

    public void VisitCompanyAccount(Company companyAcc)
    {
        string result = "<table><tr><td>Property<td><td>Value</td></tr>";
        result += "<tr><td>Name<td><td>" + companyAcc.Name + "</td></tr>";
        result += "<tr><td>RegNumber<td><td>" + companyAcc.RegNumber + "</td></tr>";
        result += "<tr><td>Number<td><td>" + companyAcc.Number + "</td></tr></table>";
        Console.WriteLine(result);
    }
}