using Facade.Example;
using Facade.Example.Systems;

public class Program
{
    public static void Main()
    {
        var textEditor = new TextEditor();
        var compiler = new Compiler();
        var environment = new CLR();
        
        var developer = new Developer();

        var facade = new IDEFacade(textEditor, compiler, environment);
        
        developer.CreateTheApp(facade);

        Console.ReadKey();
    }
}