using Interpreter.Scheme.Expressions.Abstract;

namespace Interpreter.Scheme.Expressions;

/// <summary>
/// A terminal expression which implements the Interpreter() method for terminal grammar symbols.
/// For each grammar symbol its own TerminalExpression object is created.
/// </summary>
public class TerminalExpression : IExpression
{
    public void Interpreter(Context context)
    {
        
    }
}