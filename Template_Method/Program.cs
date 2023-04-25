using Template_Method.Example.Education;

public class Program
{
    public static void Main()
    {
        var school = new School();
        var university = new University();
        
        school.Learn();
        university.Learn();
    }
}