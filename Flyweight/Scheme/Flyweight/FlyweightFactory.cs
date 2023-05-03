using System.Collections;

namespace Flyweight.Scheme.Flyweight;

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