using Bridge.Example.ProgrammingLanguages.Abstraction;

namespace Bridge.Example.Developers;

/// <summary>
/// As a specific abstraction
/// </summary>
public class CorporateDeveloper : Developer
{
    public CorporateDeveloper(ILanguage language) : base(language)
    {
    }

    public override void EarnMoney()
    {
        Console.WriteLine("Get the salary in the end of month");
    }
}