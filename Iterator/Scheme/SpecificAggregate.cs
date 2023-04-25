﻿using System.Collections;
using Iterator.Scheme.Abstraction;

namespace Iterator.Scheme;

public class SpecificAggregate : IAggregate
{
    private readonly ArrayList _item = new ArrayList();


    public object this[int index]
    {
        get => _item[index];
        set => _item.Insert(index, value);
    }

    public int Count
    {
        get => _item.Count; set{ } }
    
    public IIterator CreateIterator()
    {
        return new SpecificIterator(this);
    }
}