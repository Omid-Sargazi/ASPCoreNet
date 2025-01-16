using System;
using System.Collections.Generic;
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
                months[i-1] = new DateTime(2023,i,1).ToString();
            }

            return months;
       }
    }
}