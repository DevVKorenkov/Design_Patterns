namespace Interpreter.Scheme.Expressions.Abstract;

/// <summary>
/// Defines the interface of expression. Provides Interpreter() method.
/// </summary>
public interface IExpression
{
    void Interpreter(Context context);
}