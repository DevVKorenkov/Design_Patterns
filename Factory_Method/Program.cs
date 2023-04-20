using Factory_Method.Example.Creators;
using Factory_Method.Example.Creators.Abstraction;

public class Programm
{
    public static void Main()
    {
        Developer dev = new ConcreteHouseDeveloper("Concrete houses inc.");
        var concreteHouse = dev.Create(20);

        Console.WriteLine($@"Concrete house was built by ""{dev.Name}"". Floors in the building: {concreteHouse.FloorCount}.");

        dev = new WoodHouseDeveloper("Woodhardt and son, Wooden houses developer");
        var woodHouse = dev.Create(3);

        Console.WriteLine($@"Wooden house was built by ""{dev.Name}"". Floors in the building: {woodHouse.FloorCount}.");

        Console.ReadKey();
    }
}
