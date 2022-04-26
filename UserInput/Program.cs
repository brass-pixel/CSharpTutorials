using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: "); //Prints but doesn't go to new line
            string name = Console.ReadLine(); //User Input + sets a variable for input           
            Console.Write("Enter your age: "); 
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", you are " + age);

            Console.ReadLine();
        }
    }
}
