using MagicLandExplorer.Tasks;
using Newtonsoft.Json;

namespace MagicLandExplorer
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Construct the path to the JSON file 
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string jsonFilePath = Path.Combine(baseDirectory, "data", "MagicLandData.json");

            // Ensure the file exists
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine("The JSON file does not exist at the specified path.");
                return;
            }

            // Read the JSON file
            string jsonData = File.ReadAllText(jsonFilePath);

           
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(jsonData);

            
            if (categories == null)
            {
                Console.WriteLine("Failed to deserialize JSON data.");
                return;
            }

            
            List<Destination> destinations = GetDestinationsFromCategories(categories);

            Console.WriteLine("Welcome to Magic Land!");

            while (true)
            {
                Console.WriteLine("1- Show Destinations with duration less than 100 minutes");
                Console.WriteLine("2- Show longest duration");
                Console.WriteLine("3- Sort destinations by Name");
                Console.WriteLine("4- Show top 3 durations");
                Console.WriteLine("5- End the program");
                Console.Write("Choose one of them: ");

                string choose = Console.ReadLine();
                Console.WriteLine();
                DestinationOperation operation = null;

                switch (choose)
                {
                    case "1":
                        operation = (destinations) => new FilterDestinations().Filter(destinations, 100);
                        break;
                    case "2":
                        operation = (destinations) => new LongestDuration().DisplayLongestDuration(destinations);
                        break;
                    case "3":
                        operation = (destinations) => new SortByName().SortAndDisplayByName(destinations);
                        break;
                    case "4":
                        operation = (destinations) => new Top3Duration().DisplayTop3Durations(destinations);
                        break;
                    case "5":
                        Console.WriteLine("Ending the program.");
                        return;
                    default:
                        Console.WriteLine("Number is not between 1 and 5");
                        break;
                }

                if (operation != null)
                {
                    operation(destinations);
                }
            }
        }

        static List<Destination> GetDestinationsFromCategories(List<Category> categories)
        {
            List<Destination> destinations = new List<Destination>();
            foreach (var category in categories)
            {
                if (category.Destinations != null)
                {
                    destinations.AddRange(category.Destinations);
                }
            }
            return destinations;
        }
    }
}
