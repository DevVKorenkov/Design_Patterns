using Proxy.Example.Abstraction;
using Proxy.Example.Context;
using Proxy.Example.Mock;
using Proxy.Example.Models;

namespace Proxy.Example;

public class BookStore : IBook
{
    private PageContext _db;
    
    public Page GetPage(int number)
    {
        return _db.Pages.FirstOrDefault(p => p.Number == number);
    }
    
    public void Dispose()
    {
        _db.Dispose();
    }
}