using Observer.Example.Models;
using Observer.Example.Observable.Abstraction;
using Observer.Example.Observers.Abstraction;

namespace Observer.Example.Observers;

public class Bank : IObserver
{
    public string Name { get; set; }
    private IObservable _stock;

    public Bank(string name, IObservable observable)
    {
        Name = name;
        _stock = observable;
        _stock.AddObserver(this);
    }
    
    public void Update(object obj)
    {
        var stockInfo = obj as StockInfo;

        if (stockInfo.Euro > 40)
        {
            Console.WriteLine($"The bank {Name} sells euros; The rate is {stockInfo.Euro}");
        }
        else
        {
            Console.WriteLine($"The broker {Name} buys euros; The rate is {stockInfo.Euro}");
        }
    }
}