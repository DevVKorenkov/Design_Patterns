using Interface_Segregation_Principle.Right.EmptyMethodsResolve.Abstraction;

namespace Interface_Segregation_Principle.Right.EmptyMethodsResolve.Devices;

public class Smartphone : IVideo, ICall, IPhoto, IBrowser
{
    public void TakeVideo() => Console.WriteLine("Take a video");

    public void MakeCall() => Console.WriteLine("Make a call");

    public void TakePhoto() => Console.WriteLine("Take a photo");

    public void BrowsingInternet() => Console.WriteLine("Internet browsing");
}