using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.MealOrderingSystem
{
    public class Meal
    {
        public string MainDish {get; set;}
        public string SideDish {get; set;}
        public string Drink {get; set;}
        public bool IsComboMeal {get; set;}

        public void ShowDetails()
        {
            Console.WriteLine($"Main Dishh{MainDish}");
            Console.WriteLine($"Side Dish:{SideDish}");
            Console.WriteLine($"Drink: {Drink}");
            Console.WriteLine(IsComboMeal ? "Combo Meal: Yes (Extra Fries + Large Drink)" : "Combo Meal: No");

        }
    }
}