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
            Console.WriteLine("Euler project 3 solution is " + LargestPrimeFactor());
            Console.WriteLine("Euler project 4 solution is " + LargestPalindromeProduct());


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
            long[] fibbonacci = new long[5000];
            fibbonacci[0] = 1;
            fibbonacci[1] = 1;
            for (int i = 2; solution < 4000000; i++)
            {
                fibbonacci[i] = fibbonacci[i-1] + fibbonacci[i - 2];
                if (fibbonacci[i]%2 == 0)
                {
                    solution += fibbonacci[i];
                }
            }
            return solution;
        }

        public static long LargestPrimeFactor()
        {
            long prime = 600851475143;
            long solution = 3;
            while (solution < prime)
            {

                if (prime%solution==0 && solution%2!=0)
                {
                    prime = prime / solution;
                    solution = 3;
                }
                else
                {
                    solution++;
                }

            }

            return solution;
        }

        public static int LargestPalindromeProduct()
        {
            int solution = 0;
            int length = 0;

            int palindrome1 = 999;
            int palindrome2 = 999;

            while (palindrome1 > 800 & palindrome2 >800)
            {
                solution = palindrome1 * palindrome2;
                string solCharacters = solution.ToString();
                int solHalf = solCharacters.Length / 2;
                if (solCharacters.Length%2 == 0)
                {

                    string temp1 = solCharacters.Substring(0, solHalf);
                    char[] array = solCharacters.Substring(solHalf).ToCharArray();
                        Array.Reverse(array);
                    string temp2 = new string(array);
                    if (temp1.Equals(temp2))
                    {
                        break;
                    }
                    
                    if (palindrome1 > 801)
                    {
                        palindrome1--;
                    }
                    else
                    {
                        palindrome1 = 999;
                        palindrome2--;
                    }
                }
                else
                {
                    if (palindrome1 > 801)
                    {
                        palindrome1--;
                    }
                    else
                    {
                        palindrome1 = 999;
                        palindrome2--;
                    }
                }
            }


            return solution;
        }






        //===========================================================================================================
        public static int Template()
        {
            int solution = 0;

            return solution;
        }
    }
}
