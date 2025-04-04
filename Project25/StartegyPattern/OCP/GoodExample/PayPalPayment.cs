namespace StartegyPattern.OCP.GoodExample
{
    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment.");
        }
    }
}