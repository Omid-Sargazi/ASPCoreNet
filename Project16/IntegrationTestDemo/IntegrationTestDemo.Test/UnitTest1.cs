namespace IntegrationTestDemo.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int number1 = 3;
        int number2 = 5;
        Assert.Equal(8, add(number1, number2));
    }

    private int add(int a, int b)
    {
        return a + b;
    }
}
