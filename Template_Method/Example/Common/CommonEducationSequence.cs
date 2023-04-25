namespace Template_Method.Example.Common;

public abstract class Learning
{
    public abstract void Learn();
}

public abstract class CommonEducationSequence : Learning
{
    public sealed override void Learn()
    {
        Entrance();
        Study();
        PassExams();
        GetThePaper();
    }

    public abstract void Entrance();
    public abstract void Study();

    public virtual void PassExams()
    {
        Console.WriteLine("Pass the final exams");
    }

    public abstract void GetThePaper();
}