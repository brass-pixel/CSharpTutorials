namespace Inheritance
{
    public class chef //Super class
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish() //Virtual keyword import to allow override from subclass
        {
            Console.WriteLine("the Chef makes bbq ribs");
        }
    }
}