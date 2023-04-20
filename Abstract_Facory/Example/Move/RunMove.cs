using Abstract_Factory.Example.Move.Abstract;

namespace Abstract_Factory.Example.Move;

internal class RunMove : Movement
{
    public override void Move()
    {
        Console.WriteLine("Run");
    }
}
