using System;
using System.Collections.Generic;
using System.Linq;

namespace CardLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck().Shuffle().Take(16);

            // LINQ query style
            /* var grouped =
                from card in deck
                group card by card.Suit into suitGroup
                orderby suitGroup.Key descending
                select suitGroup; */

            // Method style
            var grouped = deck.GroupBy(card => card.Suit).OrderByDescending(group => group.Key);
            foreach (var group in grouped)
            {
                Console.WriteLine($@"Group: {group.Key}
        Count: {group.Count()}
        Minimum: {group.Min()}
        Maximum: {group.Max()}");
            }
        }

        
    }
}   
