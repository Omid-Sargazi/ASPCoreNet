using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderPattern.Models;

namespace BuilderPattern.Builders
{
    public class CarBuilder
    {
        private Car _car = new Car();


        public CarBuilder SetBrand(string brand)
        {
            _car.Brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            _car.Year = year;
            return this;
        }

        public CarBuilder SetEngine(string engine)
        {
            _car.Engine = engine;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}