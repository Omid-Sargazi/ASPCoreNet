using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.AbstarctFactory
{
    public class IThemeFactory
    {
        public void SelectTheme()
        {
            Console.WriteLine("Please Enter the theme you want to select: ");
            Console.WriteLine("1. Light");
            Console.WriteLine("2. Dark");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ICheckbox lightCheckbox = new LightCheckbox();
                    lightCheckbox.CreateCheckbox();
                    ITextBox lightTextBox = new LightTextBox();
                    lightTextBox.CreateTextBox();
                    break;
                case 2:
                    ICheckbox darkCheckbox = new DarkCheckbox();
                    darkCheckbox.CreateCheckbox();
                    ITextBox darkTextBox = new DarkTextBox();
                    darkTextBox.CreateTextBox();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }
}