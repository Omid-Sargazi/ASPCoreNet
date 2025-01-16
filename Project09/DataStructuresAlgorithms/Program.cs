using DataStructuresAlgorithms.ChapterOne;

var C1 = new ChapterOne();
int result = C1.sum(2,3);
Console.WriteLine(result);

int[] numbers=  new int[5];//Array of 5 integers;
numbers[0]=100;

int [] numberss = {1,2,3,4,5}; // Array of 5 integers;

Console.WriteLine(numberss[0]+ " "+numbers[0]);

var months = C1.StoringMonthNames();

foreach(var month in months)
{
    Console.WriteLine(month);
}