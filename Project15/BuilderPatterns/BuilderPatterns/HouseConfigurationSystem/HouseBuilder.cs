using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.HouseConfigurationSystem
{
    public class HouseBuilder
    {
        private House _house = new House();

        public HouseBuilder SetRoom(int rooms)
        {
            _house.Rooms = rooms;
            return this;
        }

        public HouseBuilder SetFloor(int floors)
        {
            _house.Floors = floors;
            return this;
        }

        public HouseBuilder AddGarage()
        {
            _house.HasGarage = true;
            return this;
        }

        public HouseBuilder AddSwimmingPool()
        {
            _house.HasSwimmingPool = true;
            return this;
        }
        
        public House Build()
        {
            return _house;
        }
    }
}