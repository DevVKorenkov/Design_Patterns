namespace Interpreter.Scheme.Expressions.Abstract;

public interface IExpression
{
    void Interpreter(Context context);
}