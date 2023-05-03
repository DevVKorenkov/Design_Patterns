using Proxy.Example.Models;

namespace Proxy.Example.Abstraction;

public interface IBook : IDisposable
{
    Page GetPages(int number);
}