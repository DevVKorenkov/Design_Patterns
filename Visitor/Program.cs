using Visitor.Example;
using Visitor.Example.Accounts;
using Visitor.Example.Visitors;

public class Program
{
    public static void Main()
    {
        var structure = new Bank();
        structure.Add(new Person { Name = "John Smith", Number = "82184931" });
        structure.Add(new Company {
            Name = "Microsoft", 
            RegNumber="ewuir32141324", 
            Number="3424131445"});
        
        structure.Accept(new HtmlSerializeVisitor());
        structure.Accept(new XmlSerializeVisitor());

        Console.ReadKey();
    }
}