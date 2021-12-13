using System;

namespace C_Sharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Dmitrii";
            byte Age = 28;
            bool Pet_Having = true;
            double Foot_Size = 42.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("I am {0} years old", Age);
            Console.WriteLine("Do I have a pet? " + Pet_Having);
            Console.WriteLine("My shoe size is {0}", Foot_Size);

            

            Console.ReadKey();
        }
    }
}
