using Composite.Example.Abstraction;

namespace Composite.Example;

/// <summary>
/// As a single component
/// </summary>
public class File : Component
{
    public File(string name) : base(name)
    {
    }
}