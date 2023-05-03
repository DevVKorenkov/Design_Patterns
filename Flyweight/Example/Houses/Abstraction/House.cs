namespace Flyweight.Example.Houses.Abstraction;

/// <summary>
/// As a flyweight
/// </summary>
public interface IHouse
{
    int Floors { get; }

    void Build(double longitude, double latitude);
}