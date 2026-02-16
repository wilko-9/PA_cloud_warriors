namespace alpha;

class Program
{
    static void Main(string[] args)
    {
        Location currentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        while(true)
        {
            Console.Clear();
            ShowLocation(currentLocation);

            Console.WriteLine();
            Console.Write("Move (N/S/E/W) or X to exit: ");
            String input = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (input == "X") break;

            Location? nextLocation = input switch
            {
                "N" => currentLocation.LocationToNorth,
                "S" => currentLocation.LocationToSouth,
                "E" => currentLocation.LocationToEast,
                "W" => currentLocation.LocationToWest,
                _ => null
            };

            if (nextLocation == null)
            {
                Console.WriteLine("You cannot go that way girl..");
                Console.WriteLine("Press any key..");
                Console.ReadKey();
            }
            else
            {
                currentLocation = nextLocation;
            }
        }
    }

    static void ShowLocation(Location location)
    {
        Console.WriteLine($"Location: {location.Name}");
        Console.WriteLine(location.Description);

        Console.WriteLine();
        Console.WriteLine("Possible moves:");

        if (location.LocationToNorth != null) Console.WriteLine("  N - North");
        if (location.LocationToSouth != null) Console.WriteLine("  S - South");
        if (location.LocationToEast != null) Console.WriteLine("   E - East");
        if (location.LocationToWest != null) Console.WriteLine("   W - West");

        // Mocht het spel getest worden dat je nergens heen kan dan wordt dit hier opgevangen <3
        if (location.LocationToNorth == null &&
            location.LocationToSouth == null &&
            location.LocationToEast == null &&
            location.LocationToWest == null)
        {
            Console.WriteLine(" (No exits)");
        }
    }
}
