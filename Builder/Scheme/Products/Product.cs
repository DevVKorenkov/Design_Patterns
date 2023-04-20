namespace Builder.Scheme.Products;

public class Product
{
    private List<object> parts = new List<object>();
    public void Add(string part)
    {
        parts.Add(part);
    }
}
