using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the four numbers: \n");
                float FirstNum = float.Parse(Console.ReadLine());
                float SecondNum = float.Parse(Console.ReadLine());
                float ThirdNum = float.Parse(Console.ReadLine());
                float FourthNum = float.Parse(Console.ReadLine());
                Console.WriteLine("The average of two numbers are {0}", ((FirstNum + SecondNum + ThirdNum + FourthNum) / 4));
                Console.ReadLine();
            }
            catch (Exception e) {
                Console.WriteLine("Invalid Input!");
                Console.ReadLine();
            }
        }
    }
}
