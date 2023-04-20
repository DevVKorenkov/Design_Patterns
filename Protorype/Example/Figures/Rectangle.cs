using Protorype.Example.Abstract;

namespace Protorype.Example.Figures;

public class Rectangle : IFigure
{
    private int _width;
    private int _height;

    public Rectangle(int w, int h)
    {
        _width = w;
        _height = h;
    }

    public IFigure Clone()
    {
        return new Rectangle(_width, _height);
    }

    public void GetInfo()
    {
        Console.WriteLine($"This rectangle has width {_width} and height {_height}");
    }
}
