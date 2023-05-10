using System.Collections;

namespace Flyweight.Scheme.Flyweight;

/// <summary>
/// Creates separated flyweights. Because flyweights are separated
/// a client doesn’t have to create by itself.
/// All created objects are saved in the objects pool.
/// If a required flyweight doesn’t exist the factory creates it.
/// </summary>
public class FlyweightFactory
{
    private Hashtable flyweights = new Hashtable();

    public FlyweightFactory()
    {
        flyweights.Add("x", new SpecificFlyweight());
        flyweights.Add("y", new SpecificFlyweight());
        flyweights.Add("z", new SpecificFlyweight());
    }

    public Abstraction.Flyweight GetFlyweight(string key)
    {
        if (!flyweights.Contains(key))
        {
            flyweights.Add(key, new SpecificFlyweight());
        }
        
        return flyweights[key] as Abstraction.Flyweight;
    }
}