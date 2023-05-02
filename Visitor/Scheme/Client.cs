using Visitor.Scheme.Objects;
using Visitor.Scheme.Objects.Elements;
using Visitor.Scheme.Visitors;

namespace Visitor.Scheme;

public class Client
{
    public void Make()
    {
        var structure = new ObjectStructure();
        
        structure.Add(new ElementA());
        structure.Add(new ElementB());
        structure.Accept(new SpecificVisitor1());
        structure.Accept(new SpecificVisitor2());
    }
}