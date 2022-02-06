using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class class1
    {
        static void Main(string[] args)
        {
            int i, n = 0, j, k = 4, m;
            float l;
            int[] array = { 1, 12, -5, -6, 50, 3 };


            for (i = 1; i < array.Length - 1; i++)
            {
                n = n + array[i];
            }

            for (i = 0; i < array.Length; i++)
                Console.Write(array[i] + ", ");

            Console.WriteLine();
            l = (float)n / k;
            Console.WriteLine(l);

            Console.ReadKey();
        }
    }
}
