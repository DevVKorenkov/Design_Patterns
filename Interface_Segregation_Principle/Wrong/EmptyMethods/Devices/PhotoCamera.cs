using Interface_Segregation_Principle.Wrong.EmptyMethods.Abstraction;

namespace Interface_Segregation_Principle.Wrong.EmptyMethods.Devices;

public class PhotoCamera : IDevice
{
    public void Call()
    {
        
    }

    public void TakePhoto() => Console.WriteLine("Take a picture");

    public void TakeVideo()
    {
        
    }

    public void BrowsingInternet()
    {
        
    }
}