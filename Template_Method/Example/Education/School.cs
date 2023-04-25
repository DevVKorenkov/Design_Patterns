using Template_Method.Example.Common;

namespace Template_Method.Example.Education;

public class School : CommonEducationSequence
{
    public override void Entrance()
    {
        Console.WriteLine("Enroll in school");
    }

    public override void Study()
    {
        Console.WriteLine("Visit classes, do homeworks");
    }

    public override void GetThePaper()
    {
        Console.WriteLine("Get the middle education paper");
    }
}