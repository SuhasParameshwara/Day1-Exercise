using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirteenPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                float num = float.Parse(Console.ReadLine());
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadKey();
        }
    }
}
