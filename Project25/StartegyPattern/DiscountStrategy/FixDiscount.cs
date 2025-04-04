namespace  StartegyPattern.DiscountStrategy
{
  public class FixDiscount : IDiscount
  {

    public decimal CalculateDiscount(decimal price)
    {
      return price - 500m; // قیمت بعد از تخفیف ثابت
    }
  }
}