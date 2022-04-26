using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall) // && is the 'and' operator
            {
                Console.WriteLine("You are a tall male");
            } 
            else if (isMale && !isTall) //! is equivalent to 'not equal to'
            {
                Console.WriteLine("You are a short male");
            } 
            else if (!isMale && isTall) 
            {
                Console.WriteLine("You are a tall female");
            }
            else
            {
                Console.WriteLine("You are not male,tall or not both");
            }


            if (isMale || isTall) // || is the 'or' operator
            {
                Console.WriteLine("You are tall or a male or both");
            } else
            {
                Console.WriteLine("You are not tall and not male");
            }


        }
    }
}
