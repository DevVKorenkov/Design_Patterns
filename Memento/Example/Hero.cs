namespace Memento.Example;

public class Hero
{
    private int _ammunition;
    private int _health;

    public Hero(int ammunition, int health)
    {
        _ammunition = ammunition;
        _health = health;

        Console.WriteLine($"The start Params: ammo - {_ammunition} , health - {_health}");
    }

    public void Shoot()
    {
        if (_ammunition > 0)
        {
            _ammunition--;
            Console.WriteLine($"A shoot was made. {_ammunition} left.");
        }
        else
        {
            Console.WriteLine("There are no ammunition any more.");
        }
    }

    public HeroMemento SaveState()
    {
        Console.WriteLine($"The game is saved. Params: ammo - {_ammunition} , health - {_health}");
        return new HeroMemento(_ammunition, _health);
    }

    public void RestoreState(HeroMemento heroMemento)
    {
        _ammunition = heroMemento.Ammunition;
        _health = heroMemento.Health;
        Console.WriteLine($"The game was loaded. Params: Params: ammo - {_ammunition} , health - {_health}");
    }
}