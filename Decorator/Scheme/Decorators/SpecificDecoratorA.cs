﻿using Decorator.Scheme.Decorators.Abstraction;

namespace Decorator.Scheme.Decorators;

/// <summary>
/// Defines extra functionality for base object
/// </summary>
public class SpecificDecoratorA : AbstractDecorator
{
    public override void Operation()
    {
        base.Operation();
    }
}
