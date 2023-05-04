using Single_Responsibility_Principle.Models;

namespace Single_Responsibility_Principle.Wrong;

public class Store
{
    private List<Phone> _phones;

    public Store()
    {
        _phones = new();
    }

    public void Process()
    {
        Console.WriteLine("Input a model: ");
        string? model = Console.ReadLine();

        Console.WriteLine("Input a price: ");
        var result = double.TryParse(Console.ReadLine(), out double price);

        if (!result || price <= 0 || string.IsNullOrWhiteSpace(model))
        {
            throw new Exception("input is wrong");
        }
        else
        {
            _phones.Add(new Phone(model, price));

            using (StreamWriter sw = new StreamWriter("store.txt", true))
            {
                sw.WriteLine(model);
                sw.WriteLine(price);
            }

            Console.WriteLine("A new phone was added successfully");
        }
    }
}