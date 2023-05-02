namespace Interpreter.Example.Expressions.Abstraction;

public interface IExpression
{
    int Interpret(Context context);
}