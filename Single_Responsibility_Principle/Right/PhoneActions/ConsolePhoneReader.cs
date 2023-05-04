using Single_Responsibility_Principle.Right.PhoneActions.Abstraction;

namespace Single_Responsibility_Principle.Right.PhoneActions;

public class ConsolePhoneReader : IPhoneReader
{
    public string?[] GetInputData()
    {
        Console.WriteLine("Input a model: ");
        string? model = Console.ReadLine();
        Console.WriteLine("Input a price: ");
        string? price = Console.ReadLine();

        return new[] { model, price };
    }
}