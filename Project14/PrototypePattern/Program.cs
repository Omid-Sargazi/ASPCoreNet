using PrototypePattern.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        Enemy prototypeEnemy = new Enemy("Globen",100,"Sword");
        Enemy clonedEnemy = (Enemy)prototypeEnemy.Clone();
        clonedEnemy.Name = "Globen Jr.";
        clonedEnemy.Dispaly();
        prototypeEnemy.Dispaly();
    }
}