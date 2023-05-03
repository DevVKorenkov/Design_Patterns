namespace Composite.Scheme;

public class Client
{
    public void Execute()
    {
        IComponent root = new Composite("Root");
        IComponent leaf = new Leaf("Leaf");

        Composite subtree = new Composite("Subtree");
        
        root.Add(leaf);
        root.Add(subtree);
        root.Display();
    }
}