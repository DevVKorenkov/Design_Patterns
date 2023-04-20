using Builder.Example;
using Builder.Example.Builders;
using Builder.Example.Builders.Abstraction;

public class Programm
{
    public static void Main()
    {
        var baker = new Baker();
        IBreadBuilder builder = new RyeBreadBuilder();
        var ryeBread = baker.Bake(builder);
        Console.WriteLine(ryeBread.ToString());

        builder = new WheatBreadBuilder();
        var wheatBread = baker.Bake(builder);
        Console.WriteLine(wheatBread.ToString());

        Console.ReadKey();
    }
}
