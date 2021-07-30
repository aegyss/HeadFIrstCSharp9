using System;
using System.Collections.Generic;

namespace HeadFirstCSharp9_9
{
    class Program
    {
        static IEnumerable<String> SimpleEnumerable()
        {
            yield return "apples";
            yield return "oranges";
            yield return "bananas";
            yield return "unicorns";
        }
        static void Main(string[] args)
        {
            foreach (var s in SimpleEnumerable()) Console.WriteLine(s);
        }
    }
}
