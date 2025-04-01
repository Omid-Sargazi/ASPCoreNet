namespace Test.OOP
{
    public class Cars : IVehicleRefuel
    {
        public void Start()
        {
            Console.WriteLine("Car started");   
        }
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
        public void Refuel()
        {
            Console.WriteLine("Car is refueling");
        }
    }
}