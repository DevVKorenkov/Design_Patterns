using Interface_Segregation_Principle.Right.EmptyMethodsResolve.Abstraction;

namespace Interface_Segregation_Principle.Right.EmptyMethodsResolve.Devices;

public class PhotoCamera : IPhoto
{
    public void TakePhoto() => Console.WriteLine("Take a picture");
}