using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;

namespace MyApp.Tests.Tests
{
    public class EmailServiceTest
    {
        [Fact]
        public async Task EmailServiceTest_RetrunsTrue()
        {
            var mockEmailService = new Mock<IEmailService>();

            mockEmailService.Setup(e =>e.SendEmailAsync("O@o.com")).ReturnsAsync(true);

            var result = await mockEmailService.Object.SendEmailAsync("O@o.com");

            Assert.True(result);
        }
    }
}