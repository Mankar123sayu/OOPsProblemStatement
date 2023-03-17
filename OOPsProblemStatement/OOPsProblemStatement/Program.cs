using System;
namespace OOPsProblemStatement
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to oops");
                InventryOperation inventry = new InventryOperation();
            inventry.ReadJsonFile(@"");
        }
    }
}