using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            Console.WriteLine("Giraffe\nAcademy");

            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("name")); // Check if contains phrase "name"
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Academy")); // Checks if contains the phrase and what index it starts at
            Console.WriteLine(phrase.Substring(8, 5)); // Prints substring at the string index, and takes how many characters to print
            Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy")) );
        }
    }
}
