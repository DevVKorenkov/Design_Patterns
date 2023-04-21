using Strategy.Example;
using Strategy.Example.Strategies;
using Strategy.Example.Strategies.Abstraction;

public class Program
{
    public static void Main()
    {
        IEngine engine = new PetrolEngine();
        var car = new Car(4, "Mercedes", engine);
        car.Move();
        
        engine = new ElectricEngine();
        car.Engine = engine;
        car.Move();

        Console.ReadKey();
    }
}