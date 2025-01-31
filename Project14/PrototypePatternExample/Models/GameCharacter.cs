using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.Models
{
    public class GameCharacter : ICloneable
    {
        public string Name {get; set;}
        public int Health {get; set;}
        public string Weapon {get; set;}

        public GameCharacter(string name, int health, string weapon)
        {
            Health = health;
            Weapon = weapon;
            Name = name;
        }

        public object Clone()
        {
            return (GameCharacter)this.MemberwiseClone();
        }
        public void Display()
        {
            Console.WriteLine($"Character: {Name}, Health: {Health}, Weapon: {Weapon}");
        }
    }
}