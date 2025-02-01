using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpPattern
{
    public class Pattern7
    {
        public void Run()
        {
            int n = 5;
            int k=1;
            for(int i = 1; i<=n; i++)
            {
                for(int j=1;j<=n ; j++)
                {
                    Console.Write(k+" ");
                    k+=2;
                }
                Console.WriteLine();
            }
        }
    }

}