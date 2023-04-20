using Singleton.Example;
using Singleton.Example.Concurrency;

public class Programm
{
    public static void Main()
    {
        var computer = new Computer();
        computer.Launch("Windows");

        Console.WriteLine(computer.OS.Name);

        // Doesn't work because the object has been already created
        computer.Launch("Linux");
        Console.WriteLine(computer.OS.Name);

        // Still doesn't work because of the same reason
        computer.OS = OS.GetInstance("Linix");
        Console.WriteLine(computer.OS.Name);

        // This is the example for several threads. The result depends on what thread performs its action earlier
        new Thread(() =>
        {
            var computer1 = new ComputerConcurrency();
            computer1.OS = OSConcurrencyResolve.GetInstance("Linux");

            Console.WriteLine(computer1.OS.Name);
        }).Start();

        var computer2 = new ComputerConcurrency();
        computer2.Launch("Windows");
        Console.WriteLine(computer2.OS.Name);

        Console.ReadKey();
    }
}
