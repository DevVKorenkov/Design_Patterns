namespace Builder.Scheme.Products;

/// <summary>
/// Presents an object to be created 
/// </summary>
public class Product
{
    private List<object> parts = new List<object>();
    public void Add(string part)
    {
        parts.Add(part);
    }
}
