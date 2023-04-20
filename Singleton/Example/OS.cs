namespace Singleton.Example;

public class OS
{
    private static OS _instance;
    public string Name { get; set; }

    protected OS(string name)
    {
        Name = name;
    }

    public static OS GetInstance(string name)
    {
        if (_instance == null)
        {
            _instance = new OS(name);
        }

        return _instance;
    }
}
