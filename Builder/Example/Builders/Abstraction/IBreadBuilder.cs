using Builder.Example.Models;

namespace Builder.Example.Builders.Abstraction;

public interface IBreadBuilder
{
    Bread Bread { get; set; }
    void CreateBread();
    void SetFlour();
    void SetSalt();
    void SetAdditives();
}
