using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class Top3Duration
    {        
        public void DisplayTop3Durations(List<Destination> destinations)
        {
            var top3Destinations = destinations
                .Where(d => !string.IsNullOrEmpty(d.Duration) &&
                            int.TryParse(d.Duration.Replace(" minutes", ""), out int _))
                .OrderByDescending(d => int.Parse(d.Duration.Replace(" minutes", "")))
                .Take(3)
                .ToList();

            if (top3Destinations.Any())
            {
                Console.WriteLine("Top 3 Destinations with the Longest Durations:");
                foreach (var destination in top3Destinations)
                {
                    Console.WriteLine($"{destination.Name}  -  {destination.Duration}");
                }
            }
            else
            {
                Console.WriteLine("No valid durations found.");
            }
            Console.WriteLine();
        }
    }
}
