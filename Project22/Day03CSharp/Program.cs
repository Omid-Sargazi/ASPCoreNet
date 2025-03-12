// See https://aka.ms/new-console-template for more information
using Day03CSharp.Models;

Console.WriteLine("Hello, World!");
int[] numbers = [10, 20, 30, 40, 50];

Console.WriteLine($" first number is{numbers[0]} ");
Console.WriteLine($"end of number is {numbers[^1]}");
Console.WriteLine($"lenght of the list is {numbers.Length}");

People people = new People("Omid",42);
people.DisplayInfo();