using Single_Responsibility_Principle.Right.PhoneActions;
using Single_Responsibility_Principle.Right.Store;

public class Program
{
    public static void Main()
    {
        var store = new Store(
        new ConsolePhoneReader(), 
        new PhoneCreator(), 
        new PhoneValidator(), 
        new PhoneWriter());
        
        store.Process();
    }
}