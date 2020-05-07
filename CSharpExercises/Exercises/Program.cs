using Exercises.Easy;
using System;

namespace Exercises
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write yor name:");
            Console.WriteLine(HelloWorld.Greet(Console.ReadLine()));
            Console.WriteLine("Write yor name:");
            Console.WriteLine(OneForMe.Speak(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}