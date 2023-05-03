using Adapter.Example;
using Adapter.Example.Adapters;
using Adapter.Example.Transport;

public class Program
{
    public static void Main()
    {
        var driver = new Driver();

        var auto = new Auto();
        
        driver.Travel(auto);

        var camel = new Camel();

        var cameAdapter = new CamelToTransportAdapter(camel);
        
        driver.Travel(cameAdapter);
    }
}