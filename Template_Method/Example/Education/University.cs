using Template_Method.Example.Common;

namespace Template_Method.Example.Education;

public class University : CommonEducationSequence
{
    public override void Entrance()
    {
        Console.WriteLine("Enroll in university");
    }

    public override void Study()
    {
        Console.WriteLine("Visit lectures");
        Console.WriteLine("Do practices");
    }

    public override void PassExams()
    {
        Console.WriteLine("Pass the speciality exams");
    }

    public override void GetThePaper()
    {
        Console.WriteLine("Get the high education paper");
    }
}