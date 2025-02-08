using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.CarBuilder
{
    public class CarBuilder
    {
        private readonly Car _car;

        public CarBuilder(Car car)
        {
            _car = car;
        }

        public CarBuilder setEngine(string engine)
        {
            _car.Engine = engine;
            return this;
        }

        public CarBuilder setColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public CarBuilder setWheels(string wheels)
        {
            _car.Wheels = wheels;
            return this;
        }

        public CarBuilder setSunroof()
        {
            _car.Sunroof = true;
            return this;
        }

        public CarBuilder setGPS()
        {
            _car.GPS = true;
            return this;
        }

        public Car car()
        {
            return _car;
        }
    }
}