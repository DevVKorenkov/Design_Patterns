using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Prototype.Example.Abstract;

namespace Prototype.Example.MemberwiseCloneExample.Figures;

[Serializable]
public class CircleMemberwiseClone : IFigure
{
    private int _radius;
    private Point _point;

    public CircleMemberwiseClone(int r, int x, int y)
    {
        _radius = r;
        _point = new Point { Y = y, X = x };
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
        Console.WriteLine($"This circle has radius {_radius}, center is in the point x = {_point.X}, y = {_point.Y}");
    }
}
