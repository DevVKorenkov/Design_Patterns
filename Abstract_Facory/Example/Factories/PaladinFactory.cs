﻿using Abstract_Factory.Example.Factories.Abstract;
using Abstract_Factory.Example.Move;
using Abstract_Factory.Example.Move.Abstract;
using Abstract_Factory.Example.Weapons;
using Abstract_Factory.Example.Weapons.Abstract;

namespace Abstract_Factory.Example.Factories;

/// <summary>
/// As a certain factory
/// </summary>
public class PaladinFactory : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new RunMove();
    }

    public override Weapon CreateWeapon()
    {
        return new Sword();
    }
}
