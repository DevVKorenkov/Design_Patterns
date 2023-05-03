using Flyweight.Scheme.Flyweight;

namespace Flyweight.Scheme;

public class Client
{
    public void Execute()
    {
        int extrinsicState = 22;

        FlyweightFactory factory = new FlyweightFactory();

        var fx = factory.GetFlyweight("x");
        fx.Operation(--extrinsicState);

        var fy = factory.GetFlyweight("y");
        fy.Operation(--extrinsicState);

        var fz = factory.GetFlyweight("z");
        fz.Operation(--extrinsicState);

        var uf = new UnsharedSpecificFlyweight();
        uf.Operation(--extrinsicState);
    }
}