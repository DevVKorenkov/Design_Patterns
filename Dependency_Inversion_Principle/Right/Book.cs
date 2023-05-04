using Dependency_Inversion_Principle.Right.Abstraction;

namespace Dependency_Inversion_Principle.Right;

public class Book
{
    public string Text { get; set; }

    // Actually, this method breaks single responsibility principle
    // and I should have made a class like "BookPrinter" or something,
    // I had to leave this class as a model
    // but let's allow it to be here this time
    public void Print(IPrinter printer)
    {
        printer.Print(Text);
    }
}