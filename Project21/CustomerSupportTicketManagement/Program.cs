using CustomerSupportTicketManagement.Calculator;
using CustomerSupportTicketManagement.LoggingSystem;
using CustomerSupportTicketManagement.MethodInjection;
using CustomerSupportTicketManagement.PaymentProcessingSystem;

public class Program
{
    public static void Main(string[] args)
    {
        ICalculator addCalculator = CalculatorFactory.CreateCalculator("Add");
        ICalculator subCalculator = CalculatorFactory.CreateCalculator("subtract");

        Console.WriteLine($"Addition 5 + 3= {addCalculator.Calculate(5,3)}");
        Console.WriteLine($"subtract 5 - 3= {subCalculator.Calculate(5,3)}");

        var consoleLogging = LoggerFactory.CreateLoggingService("console");
        consoleLogging.ProcessLog("this is a console log message");

        var creditCardPayment = PaymentCompositionRoot.CreatePaymentService("creditcard");
        var paypalPayment = PaymentCompositionRoot.CreatePaymentService("payPal");

        creditCardPayment.MakePayment(100.15m);
        paypalPayment.MakePayment(258.96m);

        var calculator = new Calculator();
        var logger = new ConsoleLoggerr();
        int sum = calculator.Add(2,3);
        Console.WriteLine($"Sum :{sum}");

        try{
            int reult = calculator.Divided(10,2,logger);
            Console.WriteLine($"Division result:{reult}");

            calculator.Divided(5,0, logger);
        }catch(DivideByZeroException)
        {
            Console.WriteLine("Division by zero exception caught");
        }
    }
}