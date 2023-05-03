using Proxy.Scheme.Abstraction;

namespace Proxy.Scheme;

/// <summary>
/// A proxy to access the real object
/// </summary>
public class ProxySubject : ISubject
{
    private RealSubject _realSubject;
    public void Request()
    {
        if (_realSubject is null)
        {
            _realSubject = new RealSubject();
        }
        
        _realSubject.Request();
    }
}