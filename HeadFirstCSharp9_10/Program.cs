using System;
using HeadFirstCSharp9_08;

namespace HeadFirstCSharp9_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new BetterSportSequence();
            foreach (var item in sequence)
                Console.WriteLine($"{item}");
        }
    }
}
