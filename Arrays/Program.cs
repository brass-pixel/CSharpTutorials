using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] luckyNumbers = { 4, 8, 15, 16, 23, 42}; //Set array with specific datatype
            string[] friends = new string[3]; //Set number of items in array
            friends[0] = "Jim"; // Assign item to array index 
            friends[1] = "Kelly";

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]); // Indexing from 0 onwards

            Console.ReadLine();
        }
    }
}
