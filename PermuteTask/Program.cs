using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermuteTask
{
    class Program
    {
        /*
        Изчислете броя на пермутациите за дадена стойност на N. 
        Известно е, че броят на пермутациите е равен на факториела на N, 
        т.е. N! = 1.2.3...N.  Рекурсивната дефиниция е N!=N*(N-1).
         */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 7 -> 5040
            

            Console.WriteLine("Number of permutations, calculated by loop: "+PermiteByLoop(n));
            Console.WriteLine();

            Console.WriteLine("Number of permutations, calculated by recursion: " + PermiteByRecursion(n));

            Console.ReadKey();
        }

        static long PermiteByLoop(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static long PermiteByRecursion(int n)
        {            
            if (n == 0)
                return 1;

            return n * PermiteByRecursion(n - 1);

        }
    }
}
