namespace Test.OOP
{
    public class CryptoPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
        Console.WriteLine("Processing cryptocurrency payment.");
        }
    }
}