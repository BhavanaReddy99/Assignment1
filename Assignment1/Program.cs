using System;


namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNo, secondNo, temp;

            Console.WriteLine("Input the First Number: ");
            firstNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Second Number: ");
            secondNo = Convert.ToInt32(Console.ReadLine());

            //Swap the numbers using a temporary variable
            temp = firstNo;
            firstNo = secondNo;
            secondNo = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine($"First Number: {firstNo}");
            Console.WriteLine($"Second Number:  {secondNo}");
          
         
        }
       
    }
}
