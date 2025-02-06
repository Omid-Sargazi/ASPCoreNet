using Moq;
using MoqExample.Interfaces;

namespace MoqExample.Test;

public class UnitTest1
{
    // [Fact]
    public void Test1()
    {

    }

    // [Fact]
    public void Add_Test()
    {
        var mockCalculator = new Mock<ICalculator>();
        mockCalculator.Setup(x => x.Add(It.IsAny<int>(),It.IsAny<int>())).Returns(5);
        var result = mockCalculator.Object.Add(2,3);
        Assert.Equal(5, result);

    }

    [Fact]
    public void Test_GetUserName()
    {
        var mockUserService =  new Mock<IUserService>();
        mockUserService.Setup(x => x.GetUserName(1)).Returns("OmidSa");
        var result = mockUserService.Object.GetUserName(1);
        Assert.Equal("OmidSa",result);
    }
}
