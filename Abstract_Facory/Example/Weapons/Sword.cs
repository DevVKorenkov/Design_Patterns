﻿using Abstract_Factory.Example.Weapons.Abstract;

namespace Abstract_Factory.Example.Weapons;

/// <summary>
/// As a certain product
/// </summary>
internal class Sword : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Sword slash");
    }
}
