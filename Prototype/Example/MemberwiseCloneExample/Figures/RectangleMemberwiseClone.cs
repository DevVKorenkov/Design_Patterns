using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Prototype.Example.Abstract;

namespace Prototype.Example.MemberwiseCloneExample.Figures;

[Serializable]
public class RectangleMemberwiseClone : IFigure
{
    private int _width;
    private int _height;
    private Point _point;

    public RectangleMemberwiseClone(int w, int h, int x, int y)
    {
        _width = w;
        _height = h;
        _point = new Point { X = x, Y = y };
    }

    public IFigure Clone()
    {
        return MemberwiseClone() as IFigure;
    }

    public object DeepCopy()
    {
        object figure = null;
        using (MemoryStream tempStream = new MemoryStream())
        {
            BinaryFormatter binFormatter = new BinaryFormatter(null,
                new StreamingContext(StreamingContextStates.Clone));

            binFormatter.Serialize(tempStream, this);
            tempStream.Seek(0, SeekOrigin.Begin);

            figure = binFormatter.Deserialize(tempStream);
        }
        return figure;
    }

    public void GetInfo()
    {
        Console.WriteLine($"This rectangle has width {_width} and height {_height}, center is in the point x = {_point.X}, y = {_point.Y}");
    }
}
