using System;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
        }

        static int cube(int num) // Can declare value to be returned
        {
            int result = num * num * num;
            return result;
        }
    }
}
