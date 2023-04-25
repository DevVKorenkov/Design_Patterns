namespace Template_Method.Scheme.CommonAlgorithm;

public abstract class Common
{
    public void TemplateMethod()
    {
        Operation1();
        Operation2();
    }

    public abstract void Operation1();
    public abstract void Operation2();
}