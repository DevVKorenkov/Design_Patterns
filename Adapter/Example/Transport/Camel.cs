using Adapter.Example.Transport.Abstraction;

namespace Adapter.Example.Transport;

/// <summary>
/// As a class to be adapted
/// </summary>
public class Camel : IAnimal
{
    public void Ride()
    {
        Console.WriteLine("Camel riding");
    }
}