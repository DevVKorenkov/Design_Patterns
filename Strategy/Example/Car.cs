using Strategy.Example.Strategies.Abstraction;
using Strategy.Scheme.Strategies.Abstractions;

namespace Strategy.Example;

public class Car
{
    protected int passengers;
    protected string model;
    
    public IEngine Engine { private get; set; }

    public Car(int passengers, string model, IEngine engine)
    {
        this.passengers = passengers;
        this.model = model;
        Engine = engine;
    }

    public void Move()
    {
        Engine.Move();
    }
}