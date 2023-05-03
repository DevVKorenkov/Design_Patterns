using Bridge.Example.ProgrammingLanguages.Abstraction;

namespace Bridge.Example.Developers;

/// <summary>
/// As a common abstraction
/// </summary>
public abstract class Developer
{
    protected ILanguage _language;

    public ILanguage Language
    {
        set => _language = value;
    }

    protected Developer(ILanguage language)
    {
        _language = language;
    }

    public virtual void DoWork()
    {
        _language.Build();
        _language.Execute();
    }

    public abstract void EarnMoney();
}