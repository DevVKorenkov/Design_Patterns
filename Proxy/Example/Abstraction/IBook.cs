using Proxy.Example.Models;

namespace Proxy.Example.Abstraction;

public interface IBook : IDisposable
{
    Page GetPage(int number);
}