using Moq;
using MoqExample.Interfaces;

namespace MoqExample.Test;

public class UnitTest1
{
    // [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void Add_Test()
    {
        var mockCalculator = new Mock<ICalculator>();
        mockCalculator.Setup(x => x.Add(It.IsAny<int>(),It.IsAny<int>())).Returns(5);
        var result = mockCalculator.Object.Add(2,3);
        Assert.Equal(5, result);

    }
}
