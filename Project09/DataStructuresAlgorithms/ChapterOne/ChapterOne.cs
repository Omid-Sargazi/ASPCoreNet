using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.ChapterOne
{
    public class ChapterOne
    {
        public int sum (int a, int b) =>a + b;


       public string[] StoringMonthNames()
       {
            string[] months = new string[12];
            for(int i=1; i<=12;i++)
            {
                months[i-1] = new DateTime(2023,i,1).ToString("MMMM");
            }

            return months;
       }


       public int[,] MultiplicationTable()
       {
        int [,] table = new int[10, 10];
        for(int i=0;i<10;i++)
        {
            for(int j=0;j<10;j++)
                table[i,j] = (i+1)*(j+1);
        }

        return table; 

       }
       

       public int[] SelectionSort(int[] arr)
       {
        for(int i=0;i<arr.Length-1;i++)
        {
            int minIndex = i;
            for (int j=i+1; j<arr.Length;j++)
                if(arr[j]<arr[minIndex])
                    minIndex=j;
            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
        }
        return arr;
       }


      public void CalculateAverage(List<double> values)
      {
        string input;
        do
        {
            Console.Write("Enter a number (or 'q' to quit): ");
            input = Console.ReadLine();
            if(double.TryParse(input, out double value))
                values.Add(value);
        }while(input !="q");
        Console.WriteLine($"Average: {values.Average()}");
        
      }

    }


}