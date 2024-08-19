# MagicLandExplorer

MagicLandExplorer is a console application that allows users to explore various destinations in a fictional "Magic Land." The application reads destination data from a JSON file, deserializes it, and provides several options for users to interact with the data.

## Features

- Display destinations with a duration of less than 100 minutes
- Show the destination with the longest duration
- Sort destinations by name
- Show the top 3 destinations with the longest durations

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)
- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) package


1. Install the required NuGet packages:
    ```sh
    dotnet restore
    ```

2. Build the project:
    ```sh
    dotnet build
    ```

### Running the Application

1. Ensure you have the JSON data file located at `data/MagicLandData.json`. The structure of the JSON file should look like this:
    ```json
    [
        {
            "CategoryItem": "Nature",
            "Destinations": [
                {
                    "Name": "Enchanted Forest",
                    "Type": "Forest",
                    "Location": "North",
                    "Duration": "120 minutes",
                    "Description": "A mystical forest filled with magical creatures."
                },
                ...
            ]
        },
        ...
    ]
    ```

2. Run the application:
    ```sh
    dotnet run
    ```

## Usage

After running the application, you will be presented with a menu. Choose an option by typing the corresponding number:

1. **Show Destinations with duration less than 100 minutes**: Displays all destinations that can be explored in less than 100 minutes.
2. **Show longest duration**: Displays the destination with the longest duration.
3. **Sort destinations by Name**: Sorts and displays the destinations alphabetically by name.
4. **Show top 3 durations**: Displays the top 3 destinations with the longest durations.
5. **End the program**: Exits the application.

## Code Structure

- `Program.cs`: Contains the main program logic and menu interface.
- `Category.cs`: Defines the `Category` class.
- `Destination.cs`: Defines the `Destination` class.
- `Tasks/FilterDestinations.cs`: Contains the logic to filter destinations by duration.
- `Tasks/LongestDuration.cs`: Contains the logic to find and display the destination with the longest duration.
- `Tasks/SortByName.cs`: Contains the logic to sort and display destinations by name.
- `Tasks/Top3Duration.cs`: Contains the logic to find and display the top 3 destinations by duration.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes. Ensure your code follows the existing style and includes appropriate tests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Thanks to [Newtonsoft.Json](https://www.newtonsoft.com/json) for JSON parsing.
- Inspired by the fictional concept of "Magic Land."

