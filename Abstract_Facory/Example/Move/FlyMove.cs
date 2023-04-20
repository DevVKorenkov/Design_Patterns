using Abstract_Factory.Example.Move.Abstract;

namespace Abstract_Factory.Example.Move;

public class FlyMove : Movement
{
    public override void Move()
    {
        Console.WriteLine("Fly");
    }
}
