using Iterator.Example.Books.Abstraction;
using Iterator.Example.Books.Models;

namespace Iterator.Example.Books;

public class Library : IBookNumerable
{
    private Book[] _books;

    public Library()
    {
        _books = new[]
        {
            new Book { Name = "The lord of the rings" },
            new Book { Name = "The Great Gatsby" },
            new Book { Name = "To Kill a Mockingbird" },
        };
    }
    
    public Book this[int index] => _books[index];

    public int Count => _books.Length;
    
    public IBookIterator CreateIterator()
    {
        return new LibraryNumerator(this);
    }
}