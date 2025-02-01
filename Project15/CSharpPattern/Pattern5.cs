using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpPattern
{
    public class Pattern5
    {
        public void Run()
        {
            Console.WriteLine("Hello");
            for(int i= 5;i>=1;i--)
            {
                for(int j=1; j<=5;j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }

    }

}