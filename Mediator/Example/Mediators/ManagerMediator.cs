using Mediator.Example.Mediators.Abstraction;
using Mediator.Example.Members;
using Mediator.Example.Members.Abstraction;

namespace Mediator.Example.Mediators;

public class ManagerMediator : IMediator
{
    public Customer Сustomer { get; set; }
    public Developer Developer { get; set; }
    public Tester Tester { get; set; }
    
    public void Send(string message, AbstractMember member)
    {
        if (member == Сustomer)
        {
            Developer.Notify(message);
        }
        else if (member == Developer)
        {
            Tester.Notify(message);
        }
        else if (member == Tester)
        {
            Сustomer.Notify(message);
        }
    }
}