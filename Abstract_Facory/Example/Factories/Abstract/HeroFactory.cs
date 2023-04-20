using Abstract_Facory.Example.Move.Abstract;
using Abstract_Facory.Example.Weapons.Abstract;

namespace Abstract_Facory.Example.Factories.Abstract;

public abstract class HeroFactory
{
    public abstract Weapon CreateWeapon();
    public abstract Movement CreateMovement();
}
