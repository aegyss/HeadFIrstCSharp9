using System;
using System.Collections.Generic;
using System.Linq;

namespace HeadFirstCSharp9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Comic> result =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby -(Comic.Prices[comic.Issue])
                select comic;

            Console.WriteLine("Hello World!");
        }
    }
}
