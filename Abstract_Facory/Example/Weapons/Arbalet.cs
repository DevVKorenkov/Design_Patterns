using Abstract_Factory.Example.Weapons.Abstract;

namespace Abstract_Factory.Example.Weapons;

/// <summary>
/// As a certain product
/// </summary>
internal class Arbalet : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Arbalet shot");
    }
}
