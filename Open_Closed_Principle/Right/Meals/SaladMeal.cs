using Open_Closed_Principle.Right.Abstraction;

namespace Open_Closed_Principle.Right.Meals;

public class SaladMeal : IMeal
{
    public void Make()
    {
        Console.WriteLine("Cuts vegetables");
        Console.WriteLine("Adds spices and greenery");
        Console.WriteLine("Adds sunflower oil");
        Console.WriteLine("Salad is ready");
    }
}