namespace Adapter.Scheme;

/// <summary>
/// Adapter to target
/// </summary>
public class Adapter : Target
{
    private Adaptable _adaptable = new Adaptable();

    public override void Request()
    {
        _adaptable.SpecificRequest();
    }
}