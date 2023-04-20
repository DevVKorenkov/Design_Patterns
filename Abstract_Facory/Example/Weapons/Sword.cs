using Abstract_Facory.Example.Weapons.Abstract;

namespace Abstract_Facory.Example.Weapons;

internal class Sword : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Sword slash");
    }
}
