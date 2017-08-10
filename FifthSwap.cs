using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the two numbers: \n");
                float FirstNum = float.Parse(Console.ReadLine());
                float SecondNum = float.Parse(Console.ReadLine());
                FirstNum = FirstNum + SecondNum;
                SecondNum = FirstNum - SecondNum;
                FirstNum = FirstNum - SecondNum;
                Console.WriteLine("After Swapping: {0},{1}", FirstNum, SecondNum);
            }
            catch (Exception e) {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadLine();
        }
    }
}
