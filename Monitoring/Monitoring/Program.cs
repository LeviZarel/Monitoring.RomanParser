using System;

namespace Monitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanBuilder builder= new RomanBuilder();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("enter number: ");
                var input = Console.ReadLine();
                var romanNumber = builder.GetRomanNumber(int.Parse(input));
                Console.WriteLine($"number {input} in roman is {romanNumber.Symbol}");
            }
        }
    }
}
