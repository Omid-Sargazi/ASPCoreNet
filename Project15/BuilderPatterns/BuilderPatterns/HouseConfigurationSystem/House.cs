using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.HouseConfigurationSystem
{
    public class House
    {
        public int Rooms {get; set;}
        public int Windows {get; set;}
        public int Floors {get; set;}
        public bool HasGarage {get; set;}
        public bool HasSwimmingPool {get; set;}

        public void ShowDetails()
        {
            Console.WriteLine($"House with {Rooms} rooms, {Windows} windows, {Floors} floors, ");
            Console.WriteLine(HasGarage ? "Include a garage":"No Garage");
            Console.WriteLine(HasSwimmingPool ? "Include a swimming pool": "No swimming.");
        }
    }
}