using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern.PrototypePattern
{
    public class Enemy : IEnemyPrototype
    {

        public string Name {get; set;}
        public int Health {get; set;}
        public string Weapon {get; set;}

        public Enemy(string name, int health, string weapon)
        {
            Name = name;
            Health = health;
            Weapon = weapon;
        }

        public IEnemyPrototype Clone()
        {
            return(IEnemyPrototype)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Enemy:{Name}, Health:{Health}, Weapon:{Weapon}");
        }
    }
}