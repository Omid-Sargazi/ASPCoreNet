namespace StartegyPattern.OCP.GoodExample
{
    public class CryptoPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing cryptocurrency payment.");
        }
    }
}