using System;

namespace C_Sharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Dmitrii";
            Console.WriteLine(MyName);

            Console.WriteLine("\tHello World!");
            Console.WriteLine("Hello \nWorld");
            Console.WriteLine("\u0023");
            Console.WriteLine(true);

            Console.ReadKey();
        }
    }
}
