using Observer.Example.Observers.Abstraction;

namespace Observer.Example.Observable.Abstraction;

public interface IObservable
{
    ICollection<IObserver> Observers { get; set; }
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}