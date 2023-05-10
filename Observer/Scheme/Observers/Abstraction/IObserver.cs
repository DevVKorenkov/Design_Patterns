namespace Observer.Scheme.Observers.Abstraction;

/// <summary>
/// Defines an observer which subscribes to an observable object 
/// </summary>
public interface IObserver
{
    void Update();
}