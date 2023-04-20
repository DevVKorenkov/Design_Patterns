namespace Singleton.Scheme;

public class Singleton
{
    private static Singleton _instance;

    protected Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }

        return _instance;
    }
}
