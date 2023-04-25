namespace State.Example.States.Abstraction;

public interface IWaterState
{
    void Heat(Water water);
    void Cold(Water water);
}