using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = 1; //while loop equivalent of a for loop
            // while (i <= 5)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            for (int i = 1; i <= 5; i++) // For Loop
             {
                 Console.WriteLine(i);
             }

             int [] luckyNumbers = {4, 8, 15, 16, 23, 42};

            for (int i = 0; i < luckyNumbers.Length; i++) // For Loop with Arrays
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }
    }
}
