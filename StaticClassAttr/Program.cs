using System;

namespace StaticClassAttr
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.getSongCount());
        }
    }
}