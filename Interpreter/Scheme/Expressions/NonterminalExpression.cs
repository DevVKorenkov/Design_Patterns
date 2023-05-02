using Interpreter.Scheme.Expressions.Abstract;

namespace Interpreter.Scheme.Expressions;

public class NonterminalExpression : IExpression
{
    private IExpression _expression1;
    private IExpression _expression2;
    public void Interpreter(Context context)
    {
        
    }
}