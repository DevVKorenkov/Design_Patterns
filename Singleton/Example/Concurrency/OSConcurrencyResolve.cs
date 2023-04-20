namespace Singleton.Example.Concurrency;

public class OSConcurrencyResolve
{
    private static OSConcurrencyResolve _instance;
    private static object _lock = new object();
    public string Name { get; set; }

    protected OSConcurrencyResolve(string name)
    {
        Name = name;
    }

    public static OSConcurrencyResolve GetInstance(string name)
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new OSConcurrencyResolve(name);
                }
            }
        }

        return _instance;
    }
}
