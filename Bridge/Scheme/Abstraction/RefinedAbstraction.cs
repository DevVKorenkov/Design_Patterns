namespace Bridge.Scheme.Abstraction;

/// <summary>
/// More specific abstraction. Expands inherited interface
/// </summary>
public class RefinedAbstraction : CommonAbstraction
{
    public RefinedAbstraction(Implementor implementor) : base(implementor)
    {
    }

    public override void Operation()
    {
        
    }
}