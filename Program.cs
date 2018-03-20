using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Project_Solutions_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Euler project 1 solution is " + MultiplesOf3And5());
            Console.WriteLine("Euler project 2 solution is " + EvenFibbonacciNumbers());



            Console.ReadKey();
        }

        public static int MultiplesOf3And5()
        {
            int solution = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    solution += i;
               
            }
            return solution;
        }

        public static long EvenFibbonacciNumbers()
        {
            long solution = 0;
            long[] fibbonacci = new long[5000000];
            fibbonacci[0] = 1;
            fibbonacci[1] = 1;
            for (int i = 2; fibbonacci[i] < 4000000; i++)
            {
                fibbonacci[i] = fibbonacci[i-1] + fibbonacci[i - 2];
                Console.Write(fibbonacci[i] + ", ");
                if (fibbonacci[i]%2 == 0)
                {
                    solution += fibbonacci[i];
                }
            }
            return solution;
        }


        public static int Template()
        {
            int solution = 0;

            return solution;
        }
    }
}
