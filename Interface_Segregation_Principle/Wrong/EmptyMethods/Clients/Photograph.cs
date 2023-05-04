using Interface_Segregation_Principle.Wrong.EmptyMethods.Abstraction;

namespace Interface_Segregation_Principle.Wrong.EmptyMethods.Clients;

public class Photograph
{
    public void TakePhotoWithEmptyMethods(IDevice device) => device.TakePhoto();
}