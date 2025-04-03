namespace Patterns.Example01
{
   public class CPU
   {
     public string Brand { get; private set; }
    public double Speed { get; private set; }
    
    public CPU(string brand, double speed)
    {
        Brand = brand;
        Speed = speed;
    }
   }
}