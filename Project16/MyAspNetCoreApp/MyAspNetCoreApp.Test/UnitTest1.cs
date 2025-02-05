namespace MyAspNetCoreApp.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int a = 3;
        int b = 5;
        Assert.Equal(80,add(a,b));
    }

    private int add(int a, int b)
    {
        return a+b;
    }
}
