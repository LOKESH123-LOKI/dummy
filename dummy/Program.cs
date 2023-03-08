using System;
namespace dummy
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to dummy project");
            Addition addition = new Addition();
            addition.add();
            Substaction substaction = new Substaction();
            substaction.sub();
        }
    }
}