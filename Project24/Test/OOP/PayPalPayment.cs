namespace Test.OOP
{
    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing payment through PayPal.");
        }
    }
}