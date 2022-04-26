using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args) // Container, Method executed when running program, void means return nothing
        {
            SayHi("Bo", 23); // Call method with argument
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age);

        }

    }
}
