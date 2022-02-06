using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    class Program
    {


        static void Main(string[] args)
        {

            int s = 5;
            string file = @"c:\input\text.txt";
            List<string> l = new List<string>();
            try
            {
                s /= 0;
            }
            catch (Exception e)
            {
                l.Add("Sxal bajaum");
                File.WriteAllLines(file, l);
            }

            Console.ReadKey();
        }
    }
}
