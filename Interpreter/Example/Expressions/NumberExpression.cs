using Interpreter.Example.Expressions.Abstraction;

namespace Interpreter.Example.Expressions;

// Terminal expression
public class NumberExpression : IExpression
{
    private string _name;
    
    public NumberExpression(string varName)
    {
        _name = varName;
    }
    
    public int Interpret(Context context) => context.GetVariable(_name);
}