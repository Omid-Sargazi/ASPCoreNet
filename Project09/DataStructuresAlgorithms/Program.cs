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

//Multi-Dimensional Arrays
//Declaration
int[,] grid = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

Console.WriteLine(grid[0,0]);


//Multiplication table

var table= C1.MultiplicationTable();

for(int i=0; i<10; i++)
    for(int j=0; j<10; j++)
        Console.Write($"{table[i, j]+"/n"+"**"}");
    Console.WriteLine();

int[] arr=[10,8,199,123,100,-10,4740,];
var sorted = C1.SelectionSort(arr);
for(int i=0;i<arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

Console.WriteLine("/////////////////////////////////////");

List<double> values = new List<double> {1.1, 1.2,1.3};
C1.CalculateAverage(values);