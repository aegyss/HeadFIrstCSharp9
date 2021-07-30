using System;

namespace HeadFirstCSharp9_Excercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var powers = new PowersOfTwo();
            foreach (var number in powers)
                Console.WriteLine($"{number}");
        }
    }
}
