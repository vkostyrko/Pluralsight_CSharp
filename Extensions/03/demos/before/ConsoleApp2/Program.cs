using ExtensionMethods.Contracts;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToUnixSeconds());
            Console.ReadLine();
        }
    }
}
