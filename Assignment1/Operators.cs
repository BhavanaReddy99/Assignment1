using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            int fNo, sNo;
            Console.WriteLine("Input First Number :");
            fNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Second Number :");
            sNo = Convert.ToInt32(Console.ReadLine());
            double add = fNo + sNo;
            Console.WriteLine($"{fNo} + {sNo} = {add}");
            double sub = fNo - sNo;
            Console.WriteLine($"{fNo} - {sNo} = {sub}");
            double mul = fNo * sNo;
            Console.WriteLine($"{fNo} * {sNo} = {mul}");
            int div = fNo / sNo;
            Console.WriteLine($"{fNo} / {sNo} = {div}");
            double modulus = fNo % sNo;
            Console.WriteLine($"{fNo} mod {sNo} = {modulus}");

        }
    }
}
