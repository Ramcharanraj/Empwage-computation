using System;

namespace empwage_computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empwage-computation program");
            
            LengthOfLines length = new LengthOfLines(4, 6, 8, 10);
            Console.WriteLine(length);
            length.PrintSomething();
        }
    }
}
