using Builder.Example.Builders.Abstraction;
using Builder.Example.Models;

namespace Builder.Example;

public class Baker
{
    public Bread Bake(IBreadBuilder builder)
    {
        builder.CreateBread();
        builder.SetFlour();
        builder.SetSalt();
        builder.SetAdditives();
        return builder.Bread;
    }
}
