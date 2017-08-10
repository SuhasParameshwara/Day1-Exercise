using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthMul
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the three numbers: \n");
                float FirstNum = float.Parse(Console.ReadLine());
                if (FirstNum == 0)
                {
                    Console.WriteLine("First Number is 0 and so the product is also 0");
                }
                else {
                    float SecondNum = float.Parse(Console.ReadLine());
                    if (SecondNum == 0) {
                        Console.WriteLine("Second Number is 0 and so the product is also 0");
                    }
                    else
                    {
                        float ThirdNum = float.Parse(Console.ReadLine());
                        if (ThirdNum == 0)
                        {
                            Console.WriteLine("Third Number is 0 and so the product is also 0");
                        }
                        else
                        {
                            Console.WriteLine("The product of three numbers are {0}", FirstNum * SecondNum * ThirdNum);
                        }
                    }
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
