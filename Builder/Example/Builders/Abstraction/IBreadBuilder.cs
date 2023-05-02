using Builder.Example.Models;

namespace Builder.Example.Builders.Abstraction;

/// <summary>
/// as a builder
/// </summary>
public interface IBreadBuilder
{
    Bread Bread { get; set; }
    void CreateBread();
    void SetFlour();
    void SetSalt();
    void SetAdditives();
}
