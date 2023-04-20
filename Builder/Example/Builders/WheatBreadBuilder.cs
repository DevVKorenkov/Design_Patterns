using Builder.Example.Builders.Abstraction;
using Builder.Example.Models;

namespace Builder.Example.Builders;

public class WheatBreadBuilder : IBreadBuilder
{
    public Bread Bread { get; set; }

    public void CreateBread()
    {
        Bread = new Bread();
    }

    public void SetAdditives()
    {
        Bread.Additives = new Additives { Name = "Bread improver" };
    }

    public void SetFlour()
    {
        Bread.Flour = new Flour { Sort = "Extreme High quality Wheat flour" };
    }

    public void SetSalt()
    {
        Bread.Salt = new Salt();
    }
}
