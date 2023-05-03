using Bridge.Example.ProgrammingLanguages.Abstraction;

namespace Bridge.Example.ProgrammingLanguages;

public class CSharpLanguage : ILanguage
{
    public void Build()
    {
        Console.WriteLine("C# code compiling by Roslyn compiler to exe file");
    }

    public void Execute()
    {
        Console.WriteLine("JIT compiler is compiling the IL code to binary code");
        Console.WriteLine("CLR is executing a binary code");
    }
}