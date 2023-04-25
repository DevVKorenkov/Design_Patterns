using Iterator.Example.Books.Abstraction;
using Iterator.Example.Books.Models;

namespace Iterator.Example.Books;

public class LibraryNumerator : IBookIterator
{
    private IBookNumerable _aggregate;
    private int _index = 0;

    public LibraryNumerator(IBookNumerable aggregate)
    {
        _aggregate = aggregate;
    }
    
    public bool HasNext()
    {
        return _index < _aggregate.Count;
    }

    public Book Next()
    {
        return _aggregate[_index++];
    }
}