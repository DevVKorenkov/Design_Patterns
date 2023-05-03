using Flyweight.Example.Houses;
using Flyweight.Example.Houses.Abstraction;

public class Program
{
    public static void Main()
    {
        var longitude = 54.67d;
        var latitude = 23.24d;

        var factory = new HouseFactory();

        for (int i = 0; i < 5; i++)
        {
            IHouse concreteHouse = factory.GetHouse("Concrete");
            if (concreteHouse != null)
            {
                concreteHouse.Build(longitude, latitude);
            }

            longitude += 0.5d;
            latitude += 0.5d;
        }

        for (int i = 0; i < 5; i++)
        {
            IHouse brickHouse = factory.GetHouse("Brick");
            if (brickHouse != null)
            {
                brickHouse.Build(longitude, latitude);
            }
            
            longitude += 0.5d;
            latitude += 0.5d;
        }
    }
}