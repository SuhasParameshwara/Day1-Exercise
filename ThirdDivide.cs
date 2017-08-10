using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the two numbers:\n");
                float FirstNum = float.Parse(Console.ReadLine());
                float SecondNum = float.Parse(Console.ReadLine());
                if (SecondNum == 0)
                {
                    Console.WriteLine("Divident Cannot be Zero!");
                }
                else
                {
                    Console.WriteLine("The division of two numbers are {0}", FirstNum / SecondNum);
                }
            }
            catch (Exception e) {
                Console.WriteLine("Invalid Number!");        
            }
            Console.ReadKey();
        }
    }
}
