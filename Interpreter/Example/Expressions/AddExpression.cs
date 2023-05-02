﻿using Interpreter.Example.Expressions.Abstraction;

namespace Interpreter.Example.Expressions;

// Non-terminal expression
public class AddExpression : IExpression
{
    private IExpression _leftExpression;
    private IExpression _rightExpression;
    
    public AddExpression(IExpression leftExpression, IExpression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public int Interpret(Context context)
        => _leftExpression.Interpret(context) + _rightExpression.Interpret(context);
}