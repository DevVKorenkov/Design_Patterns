using Proxy.Scheme.Abstraction;

namespace Proxy.Scheme;

public class Client
{
    public void Execute()
    {
        ISubject subject = new ProxySubject();
        subject.Request();
    }
}