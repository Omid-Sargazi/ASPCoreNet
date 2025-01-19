using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvideTests.Classes;

namespace Tests.TestExample
{
    public class MathTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var mathService = new MathService();
            int a = 1;
            int b = 2;

            int result = mathService.Add(a, b);

            Assert.Equal(3,result);
        }
    }
}