using System;

namespace Monitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("enter number: ");
                var input = Console.ReadLine();
                var output = Parser.BuildRomanNumber(int.Parse(input));
                Console.WriteLine($"number {input} in roman is {output.Symbol}");
            }
        }
    }
}
