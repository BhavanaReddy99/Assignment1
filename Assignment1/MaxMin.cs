using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MaxMin
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("Maximum Number :" + num1);
                Console.WriteLine("Minimum Number :" + num2);
            }
            else
            {
                Console.WriteLine("Maximum Number :" + num2);
                Console.WriteLine("Minimum Number :" + num1);
            }

            //double max = Math.Max(num1, num2);
            //double min = Math.Min(num1, num2);
            //Console.WriteLine($"Maximum number: {max}");
            //Console.WriteLine($"Minimum number: {min}");
        }
    }
}
