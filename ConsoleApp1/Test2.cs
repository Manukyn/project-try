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
            int n, k = 0;
            n = int.Parse(Console.ReadLine());

            while (n / 10 != 0)
            {
                while (n % 10 != 0)
                {
                    k = k + n % 10;
                    n = n / 10;
                }
                n = k;
                k = 0;
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
