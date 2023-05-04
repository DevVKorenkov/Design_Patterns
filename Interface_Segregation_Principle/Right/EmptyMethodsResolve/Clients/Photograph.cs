using Interface_Segregation_Principle.Right.EmptyMethodsResolve.Abstraction;

namespace Interface_Segregation_Principle.Right.EmptyMethodsResolve.Clients;

public class Photograph
{
    public void TakePhoto(IPhoto photo) => photo.TakePhoto();
}