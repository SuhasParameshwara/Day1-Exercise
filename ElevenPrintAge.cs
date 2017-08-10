using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenPrintAge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age: \n");
                float num = float.Parse(Console.ReadLine());
                Console.WriteLine("You look older than {0}", num);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Input!");
            }
            Console.ReadKey();

        }
    }
}
