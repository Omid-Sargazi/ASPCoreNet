using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern.Interfaces
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
            return (Enemy)this.MemberwiseClone();
        }

        public void Dispaly()
        {
            Console.WriteLine($"Enemy:{Name},Health: {Health},Weapon:{Weapon}");
        }
    }
}