using Abstract_Facory.Example.Factories.Abstract;
using Abstract_Facory.Example.Move.Abstract;
using Abstract_Facory.Example.Weapons.Abstract;

namespace Abstract_Facory.Example;

public class Hero
{
    private Weapon _weapon;
    private Movement _movement;

    public Hero(HeroFactory heroFactory)
    {
        _weapon = heroFactory.CreateWeapon();
        _movement = heroFactory.CreateMovement();
    }

    public void Move()
    {
        _movement.Move();
    }

    public void Hit()
    {
        _weapon.Hit();
    }
}
