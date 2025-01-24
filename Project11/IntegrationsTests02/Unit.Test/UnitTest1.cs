namespace Unit.Test;

public class UnitTest1
{
    //[Fact]
    public void Test1()
    {
        int num1 = 3;
        int num2  = 5;

        int result = num1 + num2;

        Assert.Equal(8, result);
    }
}
