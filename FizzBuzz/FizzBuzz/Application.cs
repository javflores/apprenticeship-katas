using System;

namespace FizzBuzz
{
    public class Application
    {
        public static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            Console.Write(fizzBuzz.Get(100));
            Console.ReadKey();
        }
    }
}