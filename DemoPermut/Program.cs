using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPermut
{
    class Program
    {
        // Глобални променливи
        const int n = 5;
        static int[] elements = new int[] { 0, 1, 2, 3, 4 };
        static bool[] used = new bool[n];
        static int[] perm = new int[n];

        //предефиниран метод за прилагане
        public static void Permute()
        {
            Permute(0);
        }

        // Рекурсивен метуд за намиране на пермутации без повторение
        private static void Permute(int index)
        {
            if (index >= elements.Length)
                Console.WriteLine(string.Join(" ", perm));
            else
                for (int i = 0; i < elements.Length; i++)
                    if (!used[i])
                    {
                        used[i] = true;
                        perm[index] = elements[i];
                        Permute(index + 1);
                        used[i] = false;
                    }
        }

        static void Main(string[] args)
        {
            Permute();

            Console.ReadKey();
        }
    }
}
