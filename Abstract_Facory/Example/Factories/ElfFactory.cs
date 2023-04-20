using Abstract_Facory.Example.Factories.Abstract;
using Abstract_Facory.Example.Move;
using Abstract_Facory.Example.Move.Abstract;
using Abstract_Facory.Example.Weapons;
using Abstract_Facory.Example.Weapons.Abstract;

namespace Abstract_Facory.Example.Factories;

public class ElfFactory : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new FlyMove();
    }

    public override Weapon CreateWeapon()
    {
        return new Arbalet();
    }
}
