using Builder.Scheme.Builders;
using Builder.Scheme.Builders.Abstract;
using Builder.Scheme.Products;

namespace Builder.Scheme;

public class Client
{
    public void Build()
    {
        IBuilder builder = new SpecificBuilder();
        Director director = new Director(builder);
        director.Construct();
        Product product = builder.GetResult();
    }
}
