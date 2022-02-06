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
            int i, j, n, m, k = 0, l = 0;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            int[,] array1 = new int[n, m];


            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + ", ");
                }
                Console.WriteLine();
            }

            for (i = n; i > 0; i--)
            {
                for (j = m; j > 0; j--)
                {
                    array1[k, l] = array[i - 1, j - 1];
                    l++;
                }
                k++;
                l = 0;
                Console.WriteLine();
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {

                    Console.Write(array1[i, j] + ", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}