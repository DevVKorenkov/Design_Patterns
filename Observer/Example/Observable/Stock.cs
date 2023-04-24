using Observer.Example.Models;
using Observer.Example.Observable.Abstraction;
using Observer.Example.Observers.Abstraction;

namespace Observer.Example.Observable;

public class Stock : IObservable
{
    public ICollection<IObserver> Observers { get; set; }

    private readonly StockInfo _stockInfo;

    public Stock()
    {
        Observers = new List<IObserver>();
        _stockInfo = new StockInfo();
    }
    
    public void AddObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var o in Observers)
        {
            o.Update(_stockInfo);
        }
    }

    public void Market()
    {
        Random random = new Random();
        _stockInfo.USD = random.Next(20, 40);
        _stockInfo.Euro = random.Next(30, 50);
        NotifyObservers();
    }
}