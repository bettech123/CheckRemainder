using System;

namespace CheckRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
             int dividend, divisor, remainder;

            Console.WriteLine("Enter dividend");
            dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter divisor");
            divisor = int.Parse(Console.ReadLine());

            remainder = dividend % divisor;

            Console.WriteLine("The remainder of " + dividend + " divided by " + divisor + " = " + remainder);
        }
    }
}
