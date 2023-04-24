using Observer.Example.Models;
using Observer.Example.Observable.Abstraction;
using Observer.Example.Observers.Abstraction;

namespace Observer.Example.Observers;

public class Broker : IObserver
{
    public String Name { get; set; }
    private IObservable _stock; 
    
    public Broker(string name, IObservable observable)
    {
        Name = name;
        _stock = observable;
        _stock.AddObserver(this);
    }
    
    public void Update(object obj)
    {
        var stockInfo = obj as StockInfo;

        if (stockInfo.USD > 30)
        {
            Console.WriteLine($"The broker {Name} sells dollars; The rate is {stockInfo.USD}");
        }
        else
        {
            Console.WriteLine($"The broker {Name} buys dollars; The rate is {stockInfo.USD}");
        }
    }

    public void StopTrade()
    {
        _stock.RemoveObserver(this);
        _stock = null;
    }
}