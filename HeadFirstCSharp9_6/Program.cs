using System;
using System.Collections.Generic;
using System.Linq;

namespace HeadFirstCSharp9_6
{
    class Program
    {
        static void Main(string[] args) 
        {
            var array = new[] { 1, 2, 3, 4 };
            var result = array.Select(i => i * 2);
            foreach (var i in result)
                Console.WriteLine($"{i}");



        }

        static void Method2()
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            IEnumerable<int> result =
                from v in values
                where v < 37
                orderby -v
                select v;
        }

        static void Lambda2(int[] values)
        {
            IEnumerable<int> result = values.Where<int>(i => i < 37).OrderBy<int, int>(i => -i);
        }



    }
}
