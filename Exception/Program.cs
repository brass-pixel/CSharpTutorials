try
{
    Console.Write("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter another number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num1 / num2);
}
catch(DivideByZeroException e)
{
    Console.WriteLine("Can't divide by Zero");
}
catch(FormatException e)
{
    Console.WriteLine("Please put in a whole number");
}
finally // Will always execute code even with errors
{
    Console.WriteLine("Yay we reached here!");
}


Console.ReadLine(); 