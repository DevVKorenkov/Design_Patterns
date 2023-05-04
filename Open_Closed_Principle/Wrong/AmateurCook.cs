namespace Open_Closed_Principle.Wrong;

public class AmateurCook
{
    public string Name { get; private set; }
    
    public AmateurCook(string name)
    {
        Name = name;
    }

    public void CookTheDiner()
    {
        Console.WriteLine("Peels potatoes");
        Console.WriteLine("Boils potatoes");
        Console.WriteLine("Smashes potatoes");
        Console.WriteLine("Adds spices and greenery");
        Console.WriteLine("Smashed potatoes are ready");
    }
}