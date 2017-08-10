using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelvePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                float num = float.Parse(Console.ReadLine());
                Console.WriteLine("{0} {1} {2} {3}\n{4}{5}{6}{7}", num, num, num, num, num, num, num, num);
                Console.WriteLine("{0} {1} {2} {3}\n{4}{5}{6}{7}", num, num, num, num, num, num, num, num);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
                Console.ReadLine();
            }
        }
    }
}
