namespace Patterns.Example01
{
    public class Engine
    {
        public string Type { get; set; }
        public int Horsepower { get; set; }

        public Engine(string type, int horsepower)
        {
            Type = type;
            Horsepower = horsepower;
        }

        public void Start()
        {
            Console.WriteLine($"{Type} engine with {Horsepower} HP started.");
        }
    }
}