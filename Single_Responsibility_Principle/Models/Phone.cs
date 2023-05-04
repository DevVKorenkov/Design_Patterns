namespace Single_Responsibility_Principle.Models;

public class Phone
{
    public string Model { get; set; }
    public double Price { get; set; }

    public Phone(string model, double price)
    {
        Model = model;
        Price = price;
    }
}