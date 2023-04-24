using Observer.Scheme.Observable.Abstraction;
using Observer.Scheme.Observers.Abstraction;

namespace Observer.Scheme.Observable;

public class SpecificObservable : IObservable
{
    public ICollection<IObserver> Observers { get; set; }

    public SpecificObservable()
    {
        Observers = new List<IObserver>();
    }

    public void AddObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void NotifyObserver()
    {
        foreach (var o in Observers)
        {
            o.Update();
        }
    }
}