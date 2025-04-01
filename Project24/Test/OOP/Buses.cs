namespace Test.OOP
{   
    public class Buses:IVehicleRefuel
    {
        public void Start()
        {
            Console.WriteLine("Bus started");
        }

        public void Drive()
        {
            Console.WriteLine("Bus is driving");
        }

        public void Refuel()
        {
            Console.WriteLine("Bus is refueling");
        }
    }
}