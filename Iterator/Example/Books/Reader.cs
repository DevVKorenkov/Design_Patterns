using Iterator.Example.Books.Abstraction;

namespace Iterator.Example.Books;

public class Reader
{
    public void SeeBooks(Library library)
    {
        IBookIterator iterator = library.CreateIterator();
        while (iterator.HasNext())
        {
            var book = iterator.Next();
            Console.WriteLine(book.Name);
        }
    }
}