﻿using PrototypePattern.NewPrototypePattern;
using PrototypePattern.PrototypePattern;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        // Enemy prototype = new Enemy("Goblin",100,"Swoard");

        // Enemy clonedEnemy = (Enemy)prototype.Clone();
        // clonedEnemy.Name="ORc";
        // prototype.Display();
        // clonedEnemy.Display();

        Enemis prototypes = new Enemis("Goblin",100, "Sword");
        Enemis clonedEnemies = (Enemis)prototypes.Clone();
        clonedEnemies.Name = "Orc";
        prototypes.Displays();
        clonedEnemies.Displays();
    }
}