namespace Singleton.Example.Concurrency;

public class ComputerConcurrency
{
    public OSConcurrencyResolve OS { get; set; }

    public void Launch(string osName)
    {
        OS = OSConcurrencyResolve.GetInstance(osName);
    }
}
