using Bridge.Example.ProgrammingLanguages.Abstraction;

namespace Bridge.Example.Developers;

/// <summary>
/// As a specific abstraction
/// </summary>
public class FreelanceDeveloper : Developer
{
    public FreelanceDeveloper(ILanguage language) : base(language)
    {
        
    }

    public override void EarnMoney()
    {
        Console.WriteLine("Get the input for the job");
    }
}