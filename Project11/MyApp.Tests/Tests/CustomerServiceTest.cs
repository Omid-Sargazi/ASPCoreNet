using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Moq;

namespace MyApp.Tests.Tests
{
    public class CustomerServiceTest
    {
        [Fact]
        public void TestCustomerService()
        {
            var mockCustomerService = new Mock<ICustomerService>();

            mockCustomerService.Setup(c =>c.getCustomerById(It.IsAny<int>()))
            .Returns(new Customer{Id=1, Name="omid"});

            var customer = mockCustomerService.Object.getCustomerById(1);

            Assert.Equal("omid", customer.Name);
            

        }
    }
}