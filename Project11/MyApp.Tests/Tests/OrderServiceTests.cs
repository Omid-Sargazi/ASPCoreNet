using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using MyApp.Tests.Payment;

namespace MyApp.Tests.Tests
{
    public class OrderServiceTests
    {
        [Fact]
        public void PlaceOrder_ShouldReturnTrue_WhenAllServicesSucceed()
        {
            var mockPaymentService = new Mock<IPaymentService>();
            var mockInventoryService = new Mock<IInventoryService>();

            mockPaymentService.Setup(p => p.ProcessPayment(100m)).Returns(true);
            mockInventoryService.Setup(i => i.IsItemAvailable(1,5)).Returns(true);

            var orderService = new OrderService(mockPaymentService.Object, mockInventoryService.Object);

            var result = orderService.PlaceOrder(1, 5, 100m);

            //Assert
            Assert.True(result);
            mockInventoryService.Verify(i => i.ReserveItem(1,5), Times.Once);   
            mockPaymentService.Verify(p => p.ProcessPayment(100m), Times.Once); 
        }
    }
}