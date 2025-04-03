namespace Patterns.Example01
{
    public class Computer
    {
        public string Name { get; set; }
        public CPU Processor { get; private set; }
        public RAM Memory { get; private set; }

        public Computer(string name, string cpuBrand, double cpuSpeed, int ramCapacity)
        {
            Name = name;
            Processor = new CPU(cpuBrand, cpuSpeed);
            Memory = new RAM(ramCapacity);
        }

         public void TurnOn()
    {
        Console.WriteLine($"کامپیوتر {Name} روشن شد.");
        Console.WriteLine($"پردازنده: {Processor.Brand} با سرعت {Processor.Speed} گیگاهرتز");
        Console.WriteLine($"حافظه: {Memory.Capacity} گیگابایت");
    }
    }
}