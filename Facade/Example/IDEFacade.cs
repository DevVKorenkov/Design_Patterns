using Facade.Example.Systems;

namespace Facade.Example;

public class IDEFacade
{
    private TextEditor _textEditor;
    private Compiler _compiler;
    private CLR _clr;

    public IDEFacade(
    TextEditor textEditor, 
    Compiler compiler, 
    CLR clr)
    {
        _compiler = compiler;
        _textEditor = textEditor;
        _clr = clr;
    }

    public void Start()
    {
        _textEditor.CreateTheCode();
        _textEditor.Save();
        _compiler.Compile();
        _clr.Execute();
    }

    public void Stop()
    {
        _clr.Finish();
    }
}