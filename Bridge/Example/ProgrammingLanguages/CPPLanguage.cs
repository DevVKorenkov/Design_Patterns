using Bridge.Example.ProgrammingLanguages.Abstraction;

namespace Bridge.Example.ProgrammingLanguages;

public class CPPLanguage : ILanguage
{
    public void Build()
    {
        Console.WriteLine("The C++ code Compiling to binary code");
    }

    public void Execute()
    {
        Console.WriteLine("Launch the execution file");
    }
}