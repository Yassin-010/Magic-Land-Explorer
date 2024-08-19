using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class LongestDuration
    {
        public void DisplayLongestDuration(List<Destination> destinations)
        {
            var longestDestination = destinations
                .Where(d => !string.IsNullOrEmpty(d.Duration) &&
                            int.TryParse(d.Duration.Replace(" minutes", ""), out int duration))
                .OrderByDescending(d => int.Parse(d.Duration.Replace(" minutes", "")))
                .FirstOrDefault();

            if (longestDestination != null)
            {
                Console.WriteLine($"Longest Duration: {longestDestination.Name}, Duration: {longestDestination.Duration}");
            }
            else
            {
                Console.WriteLine("No valid durations found.");
            }
            Console.WriteLine();
        }
        
    }
}
