namespace Bridge.Scheme.Abstraction;

/// <summary>
/// Defines the base interface and keeps reference to Implementor object.
/// Operation execution is delegated to Implementor's methods
/// </summary>
public abstract class CommonAbstraction
{
    protected Implementor implementor;

    public Implementor Implementor
    {
        set => implementor = value;
    }

    public CommonAbstraction(Implementor implementor)
    {
        this.implementor = implementor;
    }

    public virtual void Operation()
    {
        implementor.OperationImp();
    }
}