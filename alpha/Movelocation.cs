namespace alpha;

public static class MoveLocation
{
    public static void Move_Location_Loop(Weapon weapon, Player player)
    {
        Console.WriteLine("Hello, World!");
        Location currentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        while(true)
        {
            Console.Clear();
            ShowLocation(currentLocation);

            Console.WriteLine();
            Console.Write("Move (N/S/E/W) or X to exit: ");
            Console.Clear();
            ShowLocation(currentLocation);
            Console.WriteLine();


            start_quest.CheckForQuests(currentLocation, weapon, player);
            Console.Write("Move (N/S/E/W) or X to exit: ");
            string input = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (input == "X"){ Program.exit_game(); return; }

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
                start_quest.CheckForCombat(currentLocation, weapon, player);
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