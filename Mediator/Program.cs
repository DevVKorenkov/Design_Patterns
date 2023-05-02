using Mediator.Example.Mediators;
using Mediator.Example.Members;

public class Program
{
    public static void Main()
    {
        var mediator = new ManagerMediator();

        var customer = new Customer(mediator);
        var developer = new Developer(mediator);
        var tester = new Tester(mediator);

        mediator.Сustomer = customer;
        mediator.Developer = developer;
        mediator.Tester = tester;
        
        customer.Send("There is an order, you have to make a program");
        developer.Send("The program is done, the testing is required");
        tester.Send("The program has been tested and ready to work");

        Console.ReadKey();
    }
}