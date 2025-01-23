using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;

namespace MyApp.Tests.Tests
{
    public class OrderProcessorTests
    {
        [Fact]
        public void CompleteOrder_ShouldReturenTrue_WhenOrderProcessSuccessfully()
        {
            var mockOrderService = new Mock<IOrderService>();
            mockOrderService.Setup(s => s.ProcessOrder(1)).Returns(true);

            var processor = new OrderProcessor(mockOrderService.Object);

            var result = processor.CompleteOrder(1);

            Assert.True(result);

        }
    }
}