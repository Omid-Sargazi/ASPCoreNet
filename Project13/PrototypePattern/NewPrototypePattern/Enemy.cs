using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern.NewPrototypePattern
{
    public class Enemis : IEnemyPrototypes
    {
        public string Name {get; set;}
        public int Health {get; set;}
        public string Weapon {get; set;}

        public Enemis(string name, int health, string weapon)
        {
            Name = name;
            Health = health;
            Weapon = weapon;
        }
        public IEnemyPrototypes Clone()
        {
            return (IEnemyPrototypes)this.MemberwiseClone();        
        }

        public void Displays()
        {
            Console.WriteLine($"Enemy:{Name},Health:{Health},Weapon:{Weapon}");
        }
    }
}