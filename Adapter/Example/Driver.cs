using Adapter.Example.Transport.Abstraction;

namespace Adapter.Example;

/// <summary>
/// As a client
/// </summary>
public class Driver
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}