using System;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            students student1 = new students("Jim", "Business", 2.8);
            students student2 = new students("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }
    }
}
