using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HeadFirstCSharp9_1;

namespace JimmyLinq
{
    public class ComicAnalyzer
    {
        private static PriceRange CalculatePriceRange(Comic comic, IReadOnlyDictionary<int, decimal> prices)
        {
            if (prices[comic.Issue] < 100)
                return PriceRange.Cheap;
            else return PriceRange.Expensive;
        }

        public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(
            IEnumerable<Comic> comics, IReadOnlyDictionary<int, decimal> prices)
        {
            /*
            var grouped =
                from comic in comics
                orderby prices[comic.Issue]
                group comic by CalculatePriceRange(comic, prices) into priceGroup
                select priceGroup;
            */

            var grouped = comics
                .OrderBy(comic => prices[comic.Issue])
                .GroupBy(comic => CalculatePriceRange(comic, prices));     
                return grouped;
        }

        public static IEnumerable<string> GetReviews(IEnumerable<Comic> catalog, IEnumerable<Review> reviews)
        {
            /*var joined =
                from comic in catalog
                join review in reviews
                on comic.Issue equals review.Issue
                select $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}";
            */

            var joined = catalog.Join
                (
                reviews, 
                comic => comic.Issue,   
                review => review.Issue, 
                (comic, review) => $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}"
                );
            return joined;
        }
    }
}
