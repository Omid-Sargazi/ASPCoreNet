namespace StartegyPattern.OCP.GoodExample
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine($"Processing credit card payment of");
        }
    }
}