using Memento.Example;

public class Program
{
    public static void Main()
    {
        var hero = new Hero(10, 100);
        var gameManager = new GameHistory();
        
        hero.Shoot();

        gameManager.History.Push(hero.SaveState());
        
        hero.Shoot();
        
        hero.RestoreState(gameManager.History.Pop());
        
        hero.Shoot();

        Console.ReadKey();
    }
}