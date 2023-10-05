using System;

namespace Assignment1
{
    internal class Row
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a digit: ");
             num = Convert.ToInt32(Console.ReadLine());

            // Using Console.Write
            Console.Write("{0} {0} {0} {0}\n", num);
            Console.Write("{0}{0}{0}{0}\n", num);

            // Using string interpolation
            Console.WriteLine($"{num} {num} {num} {num}");
            Console.WriteLine($"{num}{num}{num}{num}");

            Console.ReadLine();
        }
    }
}
