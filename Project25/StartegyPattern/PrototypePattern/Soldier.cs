namespace StartegyPattern.PrototypePattern
{
    public class Soldier : ICloneable
    {
        public string Weapon { get; set; }
        public string Armor { get; set; }
        public int Health { get; set; }
        public Soldier(string weapon, string armor, int health)
            {
            Weapon = weapon;
            Armor = armor;
            Health = health;
            } 

        public ICloneable clone()
        {
            return new Soldier(this.Weapon, this.Armor, this.Health);
        }
    }
}