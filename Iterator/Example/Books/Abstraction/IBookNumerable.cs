using Iterator.Example.Books.Models;

namespace Iterator.Example.Books.Abstraction;

public interface IBookNumerable
{
    Book this[int index] { get; }
    int Count { get; }
    IBookIterator CreateIterator();
}