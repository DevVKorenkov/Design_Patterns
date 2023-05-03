using Adapter.Example.Transport.Abstraction;

namespace Adapter.Example.Transport;

/// <summary>
/// As a certain target
/// </summary>
public class Auto : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Car driving");
    }
}