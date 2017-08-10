using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourteenDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the temperature: \n");
                float num = float.Parse(Console.ReadLine());
                Console.WriteLine("Kelvin = {0}\nFahrenheit = {1}", num + 273.15, (((num * 9) / 5) + 32));
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadLine();
        }
    }
}
