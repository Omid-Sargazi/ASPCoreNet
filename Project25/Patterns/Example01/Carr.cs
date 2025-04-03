namespace Patterns.Example01
{
    public class Carr
    {
         public string Model { get; set; }
    public Engine Engine { get; private set; }
    
    public Car(string model, int horsepower, string engineType)
    {
        Model = model;
        // موتور درون سازنده خودرو ایجاد می‌شود
        Engine = new Engine(horsepower, engineType);
    }
    
    public void Start()
    {
        Console.WriteLine($"خودروی {Model} در حال روشن شدن...");
        Engine.Start();
    }
    }
}