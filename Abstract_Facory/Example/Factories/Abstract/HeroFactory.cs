﻿using Abstract_Factory.Example.Move.Abstract;
using Abstract_Factory.Example.Weapons.Abstract;

namespace Abstract_Factory.Example.Factories.Abstract;

public abstract class HeroFactory
{
    public abstract Weapon CreateWeapon();
    public abstract Movement CreateMovement();
}
