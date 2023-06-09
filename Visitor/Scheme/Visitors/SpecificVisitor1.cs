﻿using Visitor.Scheme.Objects.Elements;
using Visitor.Scheme.Visitors.Abstraction;

namespace Visitor.Scheme.Visitors;

/// <summary>
/// A certain visitor which implements Visitor method
/// </summary>
public class SpecificVisitor1 : IVisitor
{
    public void VisitElementA(ElementA elementA)
    {
        elementA.OperationA();
    }

    public void VisitElementB(ElementB elementB)
    {
        elementB.OperationB();
    }
}