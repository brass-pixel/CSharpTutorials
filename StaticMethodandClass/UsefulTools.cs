namespace StaticMethodandClass
{
    static public class UsefulTools // Can't create instance of this class
    {
        public static void SayHi(string name) // Call class method without creating instance
        {
            Console.WriteLine("Hello " + name);
        }
    }
}