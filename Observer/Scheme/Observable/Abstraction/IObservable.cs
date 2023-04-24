using Observer.Scheme.Observers.Abstraction;

namespace Observer.Scheme.Observable.Abstraction;

public interface IObservable
{
    ICollection<IObserver> Observers { get; set; } 
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObserver();
}