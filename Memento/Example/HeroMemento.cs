namespace Memento.Example;

public class HeroMemento
{
    public int Ammunition { get; private set; }
    public int Health { get; private set; }

    public HeroMemento(int ammunition, int health)
    {
        Ammunition = ammunition;
        Health = health;
    }
}