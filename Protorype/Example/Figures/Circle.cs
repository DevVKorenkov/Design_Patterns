using Protorype.Example.Abstract;

namespace Protorype.Example.Figures;

public class Circle : IFigure
{
    private int _radius;

    public Circle(int r)
    {
        _radius = r;
    }

    public IFigure Clone()
    {
        return new Circle(_radius);
    }

    public void GetInfo()
    {
        Console.WriteLine($"This circle has radius {_radius}");
    }
}
