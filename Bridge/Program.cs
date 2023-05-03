using Bridge.Example.Developers;
using Bridge.Example.ProgrammingLanguages;

public class Program
{
    public static void Main()
    {
        Developer freelancer = new FreelanceDeveloper(new CPPLanguage());
        freelancer.DoWork();
        freelancer.EarnMoney();

        freelancer.Language = new CSharpLanguage();
        freelancer.DoWork();
        freelancer.EarnMoney();

        Console.ReadKey();
    }
}