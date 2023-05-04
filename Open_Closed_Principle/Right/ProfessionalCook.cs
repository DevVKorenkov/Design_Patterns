using Open_Closed_Principle.Right.Abstraction;

namespace Open_Closed_Principle.Right;

public class ProfessionalCook
{
    public string Name { get; private set; }
    
    public ProfessionalCook(string name)
    {
        Name = name;
    }

    public void MakeAMeal(IMeal meal)
    {
        meal.Make();
    }
}