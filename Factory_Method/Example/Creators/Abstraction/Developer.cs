using Factory_Method.Example.Products.Abstraction;

namespace Factory_Method.Example.Creators.Abstraction;

/// <summary>
/// As an abstract creator
/// </summary>
public abstract class Developer
{
    private string _name;
    public string Name => _name;

    public Developer(string name)
    {
        _name = name;
    }

    public abstract House Create(int floorCount);
}
