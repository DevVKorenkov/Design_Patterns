using Interpreter.Example;
using Interpreter.Example.Expressions;
using Interpreter.Example.Expressions.Abstraction;

public class Program
{
    public static void Main()
    {
        var context = new Context();

        int x = 5;
        int y = 8;
        int z = 2;
        
        context.SetVariable("x", x);
        context.SetVariable("y", y);
        context.SetVariable("z", z);

        IExpression expression = new SubtractExpression(
            new AddExpression(
                new NumberExpression("x"), 
                new NumberExpression("y")
                ), 
                new NumberExpression("z")
            );

        var result = expression.Interpret(context);

        Console.WriteLine($"{result}");

        Console.ReadKey();
    }
}