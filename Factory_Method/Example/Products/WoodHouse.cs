﻿using Factory_Method.Example.Products.Abstraction;

namespace Factory_Method.Example.Products;

/// <summary>
/// As a certain product
/// </summary>
public class WoodHouse : House
{
    public WoodHouse(int floorCount) : base(floorCount)
    {
    }
}
