using System.Text;
using PrototypeExamples.API;

public class Program
{
    public static void Main(string[] args)
    {
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
    }
}