using Prototype.Example.Abstract;
using Prototype.Example.Figures;
using Prototype.Example.MemberwiseCloneExample.Figures;

public class Programm
{
    public static void Main()
    {
        IFigure figure = new Rectangle(30, 40);
        IFigure clone = figure.Clone();

        clone.GetInfo();

        figure = new Circle(10);
        clone = figure.Clone();

        clone.GetInfo();

        CircleMemberwiseClone figure1 = new CircleMemberwiseClone(20, 40, 30);
        CircleMemberwiseClone clone1 = figure1.DeepCopy() as CircleMemberwiseClone;

        clone1.GetInfo();

        Console.ReadKey();
    }
}
