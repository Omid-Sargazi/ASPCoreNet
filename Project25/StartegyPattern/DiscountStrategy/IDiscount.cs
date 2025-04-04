namespace  StartegyPattern.DiscountStrategy
{
    public interface IDiscount
    {
        decimal CalculateDiscount(decimal price);
    }
}