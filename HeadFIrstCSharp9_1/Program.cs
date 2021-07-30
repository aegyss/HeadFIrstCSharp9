using System;
using System.Collections.Generic;
using System.Linq;

namespace HeadFirstCSharp9_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IEnumerable<Comic> result =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby -(Comic.Prices[comic.Issue])
                select comic;
            */
            

            IEnumerable<Comic> result = Comic.Catalog.Where(comic => Comic.Prices[comic.Issue] > 500).OrderByDescending(comic => Comic.Prices[comic.Issue]);

            foreach (var element in result)
                Console.WriteLine(element);
        }
    }
}
