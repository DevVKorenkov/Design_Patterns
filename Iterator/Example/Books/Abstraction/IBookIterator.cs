using Iterator.Example.Books.Models;

namespace Iterator.Example.Books.Abstraction;

public interface IBookIterator
{
    bool HasNext();
    Book Next();
}