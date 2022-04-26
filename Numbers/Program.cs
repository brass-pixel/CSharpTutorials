using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Does operations like Python
            Console.WriteLine(5/8); // Returns 0, because the expression is in whole numbers
            Console.WriteLine((4 + 2)/(5*8));// Returns 0, because the expression is in whole numbers
            Console.WriteLine(5/2.0); // Returns 2.5, because one value is in decimals. This is doubles

            int num = 6;
            num++; //Increments num by 1
            Console.WriteLine(num);

            Console.WriteLine(Math.Abs(-40)); //Calls Math method
            Console.WriteLine(Math.Pow(-3.8,2)); 
            Console.WriteLine(Math.Round(4.6)); 
        }
    }
}
