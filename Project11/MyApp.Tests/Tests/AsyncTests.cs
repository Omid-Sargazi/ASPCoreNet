using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Tests.Tests
{
    public class AsyncTests
    {
        [Fact]
        public async Task FetchDataAsync_ShouldReturnCorrectValue()
        {
            var result = await FetchDataAsync();
            Assert.Equal("Hello World",result);

        }

        private async Task<string> FetchDataAsync()
        {
            await Task.Delay(2000);
            return "Hello World";
        }
    }
}