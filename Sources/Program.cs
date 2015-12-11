using Odaceo;
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1) {
                Console.WriteLine("Usage: hello NAME");
            } else {
                Console.WriteLine(Greeter.sayHello(args[0]));
            }
        }
    }
}
