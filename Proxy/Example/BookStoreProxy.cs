using Proxy.Example.Abstraction;
using Proxy.Example.Models;

namespace Proxy.Example;

public class BookStoreProxy : IBook
{
    private List<Page> _pages;
    private BookStore _bookStore;

    public BookStoreProxy()
    {
        _pages = new List<Page>();
    }
    
    public Page GetPages(int number)
    {
        var page = _pages.FirstOrDefault(p => p.Number == number);
        if (page is null)
        {
            if (_bookStore is null)
            {
                _bookStore = new BookStore();
            }

            page = _bookStore.GetPages(number);
            _pages.Add(page);
        }

        return page;
    }
    
    public void Dispose()
    {
        if(_bookStore != null)
            _bookStore.Dispose();
    }
}