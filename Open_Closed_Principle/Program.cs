using Open_Closed_Principle.Right;
using Open_Closed_Principle.Right.Meals;
using Open_Closed_Principle.Wrong;

public class Program
{
    public static void Main()
    {
        #region Wrong way

        var amateurCook = new AmateurCook("Tom");
        amateurCook.CookTheDiner();

        #endregion

        #region Right way

        var professionalCook = new ProfessionalCook("Bob");
        professionalCook.MakeAMeal(new SaladMeal());
        Console.WriteLine("___________________________________");
        professionalCook.MakeAMeal(new SmashedPotatoesMeal());

        #endregion
    } 
}