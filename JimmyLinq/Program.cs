using System;
using HeadFirstCSharp9_1;
using System.Collections.Generic;
using System.Linq;

namespace JimmyLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /* var done = false;
            while (!done)
            {
                Console.WriteLine("\nPress G to group comics by price. R to get reviews. Any other key to quit.\n");
                switch (Console.ReadKey(true).KeyChar.ToString().ToUpper())
                {
                    case "G":
                        done = GroupComicsByPrice();
                        break;
                    case "R":
                        done = GetReviews();
                        break;
                    default:
                        done = true;
                        break;
                }
            }*/
            var done = false;
            while (!done)
            {
                Console.WriteLine("\nPress G to group comics by price. R to get reviews. Any other key to quit.");
                done = Console.ReadKey(true).KeyChar.ToString().ToUpper() switch
                {
                    "G" => GroupComicsByPrice(),
                    "R" => GetReviews(),
                    _ => ConfirmSelection(),
                };
            }    

           
        }

        private static bool GroupComicsByPrice()
        {
            var groups = ComicAnalyzer.GroupComicsByPrice(Comic.Catalog, Comic.Prices);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} comics:");
                foreach (var comic in group)
                    Console.WriteLine($"#{comic.Issue} {comic.Name}: {Comic.Prices[comic.Issue]:c}");
            }
            return false;
        }

        private static bool GetReviews()
        {
            var reviews = ComicAnalyzer.GetReviews(Comic.Catalog, Comic.Reviews);
            foreach (var review in reviews)
            {
                Console.WriteLine(review);
            }
            return false;
        }

        private static bool ConfirmSelection()
        {
            Console.WriteLine("Are you sure you want to quit? Y for yes. N for no. Anything else for no.");
            var done = Console.ReadKey().KeyChar.ToString().ToUpper() switch
            {
                "Y" => true,
                "N" => false,
                _ => false,
            };
            return (done);
        }
    }
}
