using Abstract_Facory.Example.Weapons.Abstract;

namespace Abstract_Facory.Example.Weapons;

internal class Arbalet : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Arbalet shot");
    }
}
