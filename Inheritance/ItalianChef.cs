namespace Inheritance
{
    class ItalianChef : chef //Inherits class from Chef, subclass
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

         public override void MakeSpecialDish() //override keyword overrides original method
        {
            Console.WriteLine("the Chef makes chicken parma");
        }
    }
}