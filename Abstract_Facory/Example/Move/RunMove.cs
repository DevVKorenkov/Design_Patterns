using Abstract_Factory.Example.Move.Abstract;

namespace Abstract_Factory.Example.Move;

/// <summary>
/// As a certain product
/// </summary>
internal class RunMove : Movement
{
    public override void Move()
    {
        Console.WriteLine("Run");
    }
}
