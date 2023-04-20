using Abstract_Factory.Example.Weapons.Abstract;

namespace Abstract_Factory.Example.Weapons;

internal class Arbalet : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Arbalet shot");
    }
}
