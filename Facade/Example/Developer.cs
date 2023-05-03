namespace Facade.Example;

public class Developer
{
    public void CreateTheApp(IDEFacade ideFacade)
    {
        ideFacade.Start();
        ideFacade.Stop();
    }
}