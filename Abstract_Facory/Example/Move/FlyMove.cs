using Abstract_Facory.Example.Move.Abstract;

namespace Abstract_Facory.Example.Move;

public class FlyMove : Movement
{
    public override void Move()
    {
        Console.WriteLine("Fly");
    }
}
