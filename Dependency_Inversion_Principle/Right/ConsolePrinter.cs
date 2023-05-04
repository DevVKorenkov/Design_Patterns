using Dependency_Inversion_Principle.Right.Abstraction;

namespace Dependency_Inversion_Principle.Right;

public class ConsolePrinter : IPrinter
{
    public void Print(string text) => Console.WriteLine(text);
}