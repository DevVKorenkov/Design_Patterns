using Abstract_Facory.Example.Move.Abstract;

namespace Abstract_Facory.Example.Move;

internal class RunMove : Movement
{
    public override void Move()
    {
        Console.WriteLine("Run");
    }
}
