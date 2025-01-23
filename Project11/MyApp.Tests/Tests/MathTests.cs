using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Tests.Tests
{
    public class MathTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnSum()
        {
            int number1 = 5;
            int number2 = 3;

            int result = number1 + number2;
            Assert.Equal(8, result);
        }

        [Theory]
        [InlineData(2,3,5)]
        [InlineData(7,8,15)]
        [InlineData(1,2,3)]
        public void Add_ShouldReturnCorrectSum(int num1, int num2, int expected)
        {
            int result = num1 + num2;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("o","m","om")]
        public void Add_ShouldReturnCorrect(string str1, string str2, string expected)
        {
            string result = str1 + str2;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            int num1 = 10;
            int num2 = 0;

            Assert.Throws<DivideByZeroException>(()=>Divid(num1, num2));
        }

        public int Divid(int a, int b)
        {
            return a/b;
        }
    }
}