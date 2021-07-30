using System;

namespace HeadFirstCSharp9_4
{
    class Program
    {
        static Random random => new Random();
        static double GetRandomDouble(int max) => max * random.NextDouble();
        
        static void PrintValue(double d) => Console.WriteLine($"The value is {d:0.0000}");
        
        static void Main(string[] args)
        {
            while (true)
            {
                var value = Program.GetRandomDouble(100);
                Program.PrintValue(value);
                Console.ReadKey(true);
            }
        }
    }
}
