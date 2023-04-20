using Abstract_Factory.Example;
using Abstract_Factory.Example.Factories;

public class Programm
{
    public static void Main()
    {
        Hero elf = new Hero(new ElfFactory());
        elf.Move();
        elf.Hit();

        Hero paladin = new Hero(new PaladinFactory());
        paladin.Move(); 
        paladin.Hit();

        Console.ReadKey();
    }
}