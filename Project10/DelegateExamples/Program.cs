using System.Security.Cryptography.X509Certificates;

namespace DelegateExamples
{
    public class Program
    {
        public delegate void MyDelegate(string msg);
        public static void Main(string[] args)
        {
            Console.WriteLine("Delegate");
            MyDelegate del = new MyDelegate(DisplayMessage);
            del("omid");
            
        }

        public static void DisplayMessage(string msg)
        {
            Console.WriteLine(msg);
        }



    }
}