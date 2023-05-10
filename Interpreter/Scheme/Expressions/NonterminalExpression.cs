using Interpreter.Scheme.Expressions.Abstract;

namespace Interpreter.Scheme.Expressions;

/// <summary>
/// A non terminal expression, defines a grammar rule.
/// For each grammar rule its own NonterminalExpression object is created.
/// </summary>
public class NonterminalExpression : IExpression
{
    private IExpression _expression1;
    private IExpression _expression2;
    public void Interpreter(Context context)
    {
        
    }
}