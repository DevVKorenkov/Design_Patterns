using State.Example.States;
using State.Example.States.Abstraction;

namespace State.Example;

public class Water
{
    public IWaterState State { get; set; }
    
    public Water(IWaterState waterState)
    {
        State = waterState;
    }

    public void Heat()
    {
        State.Heat(this);
    }

    public void Cold()
    {
        State.Cold(this);
    }
}