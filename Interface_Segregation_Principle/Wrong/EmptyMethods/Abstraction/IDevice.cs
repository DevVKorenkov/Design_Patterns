namespace Interface_Segregation_Principle.Wrong.EmptyMethods.Abstraction;

public interface IDevice
{
    void Call();
    void TakePhoto();
    void TakeVideo();
    void BrowsingInternet();
}