using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Multiply
    {
        static void Main(string[] args)
        {
            int firstNo, secondNo, thirdNo;
            Console.WriteLine("Input First Number to multiply:");
            firstNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second Number to multiply:");
            secondNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third Number to multiply:");
            thirdNo = Convert.ToInt32(Console.ReadLine());
            int ans = firstNo * secondNo * thirdNo;
            Console.WriteLine($"{firstNo} * {secondNo} * {thirdNo} = {ans}");
            Console.ReadLine();
        }
    }
}
