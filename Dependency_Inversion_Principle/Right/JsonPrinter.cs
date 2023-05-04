using System.Text.Json;
using Dependency_Inversion_Principle.Right.Abstraction;

namespace Dependency_Inversion_Principle.Right;

public class JsonPrinter : IPrinter
{
    public void Print(string text) => JsonSerializer.Serialize(text);
}