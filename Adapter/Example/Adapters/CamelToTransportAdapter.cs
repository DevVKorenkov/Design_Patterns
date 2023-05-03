using Adapter.Example.Transport;
using Adapter.Example.Transport.Abstraction;

namespace Adapter.Example.Adapters;

/// <summary>
/// As an adapter
/// </summary>
public class CamelToTransportAdapter : ITransport
{
    private Camel _camel;

    public CamelToTransportAdapter(Camel camel)
    {
        _camel = camel;
    }

    public void Drive()
    {
        _camel.Ride();
    }
}