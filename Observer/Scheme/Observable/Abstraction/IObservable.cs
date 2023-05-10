using Observer.Scheme.Observers.Abstraction;

namespace Observer.Scheme.Observable.Abstraction;

/// <summary>
/// Defines an observable object. 
/// </summary>
public interface IObservable
{
    ICollection<IObserver> Observers { get; set; } 
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObserver();
}