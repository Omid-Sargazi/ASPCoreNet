namespace Test.OOP  
{
    public class Bicycles:IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bicycle started.");
        }

        public void Drive()
        {
            Console.WriteLine("Bicycle is driving.");
        }
    }
}