using Proxy.Example;
using Proxy.Example.Abstraction;
using Proxy.Example.Models;

public class Program
{
    public static void Main()
    {
        using(IBook book = new BookStoreProxy())
        {
            
            Page page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);
            
            Page page2 = book.GetPage(2);
            Console.WriteLine(page2.Text);
              
            page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);
        }
             
        Console.Read();
    }
}