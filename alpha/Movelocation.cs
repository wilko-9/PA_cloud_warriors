namespace alpha;

public static class MoveLocation
{
    public static void Move_Location_Loop(Weapon weapon, Player player)
    {
        Location currentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        while(true)
        {
            Console.Clear();
            ShowLocation(currentLocation);
            Console.WriteLine();


            start_quest.CheckForQuests(currentLocation, weapon, player);
            Console.Clear();
            ShowLocation(currentLocation);
            Console.WriteLine();
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
            else if (nextLocation.ID == World.LOCATION_ID_BRIDGE &&
                     (!World.QuestByID(World.QUEST_ID_CLEAR_ALCHEMIST_GARDEN).IsCompleted ||
                      !World.QuestByID(World.QUEST_ID_CLEAR_FARMERS_FIELD).IsCompleted))
            {
                Console.WriteLine("The guard blocks your path!");
                Console.WriteLine("You must complete the other quests before passing.");
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
        Console.WriteLine($"You are at: {location.Name}");
        Console.WriteLine(location.Description);

        if (location.MonsterLivingHere != null)
            Console.WriteLine($"You see a {location.MonsterLivingHere.Name} here!");

        if (location.QuestAvailableHere != null && !location.QuestAvailableHere.IsAccepted)
            Console.WriteLine($"A quest is available here!");

        bool hasN = location.LocationToNorth != null;
        bool hasS = location.LocationToSouth != null;
        bool hasE = location.LocationToEast  != null;
        bool hasW = location.LocationToWest  != null;

        if (!hasN && !hasS && !hasE && !hasW)
        {
            Console.WriteLine("\n  (No exits)");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("From here you can go:");
        Console.WriteLine();

        // kompas
        string n = hasN ? "N" : " ";
        string s = hasS ? "S" : " ";
        string e = hasE ? "E" : " ";
        string w = hasW ? "W" : " ";

        Console.WriteLine($"       {n}");
        Console.WriteLine( "       |");
        Console.WriteLine($"   {w}---|---{e}");
        Console.WriteLine( "       |");
        Console.WriteLine($"       {s}");

        // locatie-namen
        Console.WriteLine();
        if (hasN) Console.WriteLine($"  N: {location.LocationToNorth!.Name}");
        if (hasS) Console.WriteLine($"  S: {location.LocationToSouth!.Name}");
        if (hasE) Console.WriteLine($"  E: {location.LocationToEast!.Name}");
        if (hasW) Console.WriteLine($"  W: {location.LocationToWest!.Name}");
    }

}