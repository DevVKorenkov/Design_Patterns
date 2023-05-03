using Adapter.Example.Transport;
using Adapter.Example.Transport.Abstraction;

namespace Adapter.Example.Adapters;

public class TransportToCamelAdapter : IAnimal
{
    private Auto _auto;
    
    public void Ride(Auto auto)
    {
        _auto = new Auto();
    }

    public void Ride()
    {
        _auto.Drive();
    }
}