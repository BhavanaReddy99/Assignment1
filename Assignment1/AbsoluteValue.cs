using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AbsoluteValue
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double absoluteDifference = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                double result = 2 * absoluteDifference;
                Console.WriteLine($"Double the absolute difference: {result}");
            }
            else
            {
                Console.WriteLine($"Absolute difference: {absoluteDifference}");
            }

            Console.ReadLine();
        }
    }
   
    }

