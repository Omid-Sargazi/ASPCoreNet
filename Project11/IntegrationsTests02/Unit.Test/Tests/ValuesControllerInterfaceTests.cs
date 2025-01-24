using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Test.Controllers;
using API.Test.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Unit.Test.Tests
{
    public class ValuesControllerInterfaceTests
    {
        [Fact]
        public void Get_ReturnsValue()
        {
            var mockService = new Mock<IValueService>();
            mockService.Setup(service => service.GetValue(1)).Returns("value1");

            var controller = new ValuesController(mockService.Object);

            var result = controller.Get(1);

            var okResult = Assert.IsType<OkObjectResult>(result);

            Assert.Equal("value1",okResult.Value);
        }

        [Fact]
        public void Get_ReturnsNotFound()
        {
            var mockService = new Mock<IValueService>();
            mockService.Setup(service => service.GetValue(1)).Returns((string)null);

            var controller = new ValuesController(mockService.Object);

            var result = controller.Get(1);

            Assert.IsType<NotFoundResult>(result);

        }
    }
}