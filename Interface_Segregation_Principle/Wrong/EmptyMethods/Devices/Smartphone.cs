using Interface_Segregation_Principle.Wrong.EmptyMethods.Abstraction;

namespace Interface_Segregation_Principle.Wrong.EmptyMethods.Devices;

public class Smartphone : IDevice
{
    public void Call() => Console.WriteLine("Make a call");

    public void TakePhoto() => Console.WriteLine("Take a picture");

    public void TakeVideo() => Console.WriteLine("Take a video"); 

    public void BrowsingInternet() => Console.WriteLine("Internet browsing");
}