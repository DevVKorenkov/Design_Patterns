using Open_Closed_Principle.Right.Abstraction;

namespace Open_Closed_Principle.Right.Meals;

public class SmashedPotatoesMeal : IMeal
{
    public void Make()
    {
        Console.WriteLine("Peels potatoes");
        Console.WriteLine("Boils potatoes");
        Console.WriteLine("Smashes potatoes");
        Console.WriteLine("Adds spices and greenery");
        Console.WriteLine("Smashed potatoes are ready");
    }
}