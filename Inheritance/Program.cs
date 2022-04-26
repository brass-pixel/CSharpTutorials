using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            chef chef = new chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();
            
        }
    }
}