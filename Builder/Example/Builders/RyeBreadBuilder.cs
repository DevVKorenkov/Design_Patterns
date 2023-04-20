using Builder.Example.Builders.Abstraction;
using Builder.Example.Models;

namespace Builder.Example.Builders;

internal class RyeBreadBuilder : IBreadBuilder
{
    public Bread Bread { get; set; }

    public void CreateBread()
    {
        Bread = new Bread();
    }

    public void SetAdditives()
    {
        
    }

    public void SetFlour()
    {
        Bread.Flour = new Flour { Sort = "High quality Rye flour" };
    }

    public void SetSalt()
    {
        Bread.Salt = new Salt();
    }
}
