using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);
            string text = Console.ReadLine();
            Console.WriteLine("Hello World!"+text);
            Console.ReadKey(true);
        }
    }
}
