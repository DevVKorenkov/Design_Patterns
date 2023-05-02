namespace Factory_Method.Example.Products.Abstraction;

/// <summary>
/// As an abstract product
/// </summary>
public abstract class House
{
    private int _floorCount;
    public int FloorCount => _floorCount;

    public House(int floorCount)
    {
        _floorCount = floorCount;
    }
}
