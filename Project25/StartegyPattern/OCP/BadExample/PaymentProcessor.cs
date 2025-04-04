namespace StartegyPattern.OCP.BadExample
{
    public class PaymentProcessor
    {
        public void ProcessPayment(string method)
        {
            if(method == "CreditCard")
            {
                Console.WriteLine("Processing credit card payment.");
            }
            else if(method == "PayPal")
            {
                Console.WriteLine("Processing PayPal payment.");
            }
            else if(method == "BankTransfer")
            {
                Console.WriteLine("Processing bank transfer payment.");
            }
            else
            {
                throw new NotSupportedException("Payment method not supported.");
            }
        }
    }
}