namespace StartegyPattern.PrototypePattern
{
    public class Soldire
    {
        public string Weapon { get; set; }
        public string Armor { get; set; }
        public int Health { get; set; }

     public Soldire(string weapon, string armor, int health)
        {
            Weapon = weapon;
            Armor = armor;
            Health = health;
        }

        public Soldier Copy()
        {
            return new Soldier(this.Weapon, this.Armor, this.Health);
        }
    }
}
