using Builder.Scheme.Builders.Abstract;

namespace Builder.Scheme;

/// <summary>
/// Disposer - makes an object, using builder objects 
/// </summary>
public class Director
{
    private readonly IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}
