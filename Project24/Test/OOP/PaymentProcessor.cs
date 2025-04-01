namespace Test.OOP
{
    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentMethod)
        {
            switch (paymentMethod)
            {
                case "CreditCard":
                    Console.WriteLine("Processing credit card payment...");
                    break;
                case "PayPal":
                    Console.WriteLine("Processing PayPal payment...");
                    break;
                case "BankTransfer":
                    Console.WriteLine("Processing bank transfer payment...");
                    break;
                default:
                    Console.WriteLine("Unknown payment method.");
                    break;
            }
        }
    }
}