using Iterator.Example.Books;

public class Program
{
    public static void Main()
    {
        var reader = new Reader();
        var library = new Library();
        
        reader.SeeBooks(library);
    }
}