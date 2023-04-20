using Abstract_Factory.Example.Factories.Abstract;
using Abstract_Factory.Example.Move.Abstract;
using Abstract_Factory.Example.Weapons.Abstract;

namespace Abstract_Factory.Example;

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
