namespace Bridge.Scheme.Abstraction;

/// <summary>
/// Defines the base interface for certain implementations.
/// Usually Implementor only defines primitive operations.
/// More complicated operations are defined in CommonAbstraction
/// </summary>
public abstract class Implementor
{
    public abstract void OperationImp();
}