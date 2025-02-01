using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpPattern
{
    public class Pattern1
    {
        public void Run()
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=5; j++)
                {
                    Console.Write("*");
                }   
                
                Console.WriteLine();
            }
        }
    }
}