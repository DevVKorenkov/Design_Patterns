namespace State.Scheme.States.Abstraction;

public interface IState
{
    void Handle(Context context);
}