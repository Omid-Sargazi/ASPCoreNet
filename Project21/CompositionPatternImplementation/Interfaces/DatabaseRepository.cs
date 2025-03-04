using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompositionPatternImplementation.Models;

namespace CompositionPatternImplementation.Interfaces
{
    public class DatabaseRepository : IRepository
    {
        public void Save(User user)
        {
            Console.WriteLine("Data is saved");
        }
    }
}