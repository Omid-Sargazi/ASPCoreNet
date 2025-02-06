using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoqExample.Interfaces;

namespace MoqExample.Implements
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a+b;
        }
    }
}