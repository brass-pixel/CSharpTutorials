using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexfirst = 1;
            while (indexfirst <= 5) //normal while loop
            {
                Console.WriteLine(indexfirst);
                indexfirst++;
            } 

            int index = 6;
            do // executes below code once before going into while loop
            {
                Console.WriteLine(index);
                index++;
            }  while (index <= 5);

        }
    }
}
