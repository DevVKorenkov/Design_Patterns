namespace Prototype.Example.Abstract;

/// <summary>
/// As a prototype
/// </summary>
public interface IFigure
{
    IFigure Clone();
    void GetInfo();
}
