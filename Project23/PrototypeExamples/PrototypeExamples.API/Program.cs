using System.Linq.Expressions;
using System.Text;
using PrototypeExamples.API;
using PrototypeExamples.API.ImplementingIDisposable;

public class Program
{
    public static void Main(string[] args)
    {

        /// <summary>
        /// /////////////////////////EXpresson Tree///////////////////////////
        /// </summary>
        /// <returns></returns>
        Expression<Func<int, int, int>>addExpression = (x,y) => x-y;
        Expression<Func<int, int, int>> addExpression2 = (x, y) => x + y;
        Func<int, int, int> addFunction = addExpression2.Compile();
        int result = addFunction(2,3);
        Console.WriteLine($"Result:{result}");
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/PrototypePizza",()=>{
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== PIZZA PROTOTYPE EXAMPLE ===");

            Pizza margheritaPrototype = new MargheritaPizza();
            Pizza pepperoniPrototype = new PepperoniPizza();

            sb.AppendLine("Original Margherita Toppings: " 
                          + string.Join(", ", margheritaPrototype.Toppings));

            sb.AppendLine("Original Pepperoni Toppings: " 
                          + string.Join(", ", pepperoniPrototype.Toppings));

                          sb.AppendLine();

            // 2) Clone them
            Pizza clonedMargherita = margheritaPrototype.Clone();
            Pizza clonedPepperoni = pepperoniPrototype.Clone();

            // 3) Show we can modify clone without affecting original
            clonedMargherita.Toppings.Add("Extra Cheese");
            clonedPepperoni.Toppings.Remove("Pepperoni"); // suppose we want a mild version

            sb.AppendLine("After modifying clones:");
            sb.AppendLine("Margherita Prototype Toppings: " 
                          + string.Join(", ", margheritaPrototype.Toppings));
            sb.AppendLine("Cloned Margherita Toppings: " 
                          + string.Join(", ", clonedMargherita.Toppings));

            sb.AppendLine("Pepperoni Prototype Toppings: " 
                          + string.Join(", ", pepperoniPrototype.Toppings));
            sb.AppendLine("Cloned Pepperoni Toppings: " 
                          + string.Join(", ", clonedPepperoni.Toppings));

            return sb.ToString();


            

        });
            app.Run();


         using (var fileHandler = new FileHandler("example.txt"))
        {
            fileHandler.writeToFile("Hello, World!");
        } // Dispose is called automatically here


    }
}