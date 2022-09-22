using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        { 
         int count = 0;
         Console.WriteLine("1 to 100 Prime Numbers:");
         for (int i = 2; i <= 100; i++)
         {
           for (int j = 2; j <= 100; j++)
           {
             if(i%j==0)
             count++;
           }
           if (count == 1)
           {
           Console.WriteLine(i);
           }
           count = 0;
         }
            Console.ReadLine();
        }
    }
}

