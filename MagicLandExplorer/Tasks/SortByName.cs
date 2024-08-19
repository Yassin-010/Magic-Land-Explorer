using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class SortByName
    {
        public void SortAndDisplayByName(List<Destination> destinations)
        {
            var sortedDestinations = destinations
                .Where(d => !string.IsNullOrEmpty(d.Name))
                .OrderBy(d => d.Name)
                .ToList();

            if (sortedDestinations.Any())
            {
                foreach (var destination in sortedDestinations)
                {
                    Console.WriteLine($"{destination.Name}");
                }
            }
            else
            {
                Console.WriteLine("No destinations found to sort.");
            }
            Console.WriteLine();
        }
    }
}
