using Observer.Example.Observable;
using Observer.Example.Observers;

public class Program
{
    public static void Main()
    {
        var stock = new Stock();
        var bank = new Bank("UnionBank", stock);
        var broker = new Broker("Trade mega corp.", stock);
        
        stock.Market();
        
        broker.StopTrade();
        
        stock.Market();
    }
}