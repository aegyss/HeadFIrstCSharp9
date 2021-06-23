using System;

namespace HeadFirstCSharp9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var whatAmI = new { Color = "Blue", Flavor = "Tasty", Height = 37};
            Console.WriteLine(whatAmI);
        }
    }
}
