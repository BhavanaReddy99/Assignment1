using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Test
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter First number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            z = Convert.ToInt32(Console.ReadLine());
            int ans1 = (x + y) * z;
            int ans2 = (x * y) + (y * z);
            Console.WriteLine($"Result of specified numbers 5, 6 and 7, (x + y) * z is {ans1} and x.y + y.z is {ans2}");
        }
    }
}
