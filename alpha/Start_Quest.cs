namespace alpha;
// logica voor quests te starten, kijkt naar locatie en geeft quest details als die er zijn.
public class start_quest
{
    public static void CheckForQuests(Location currentLocation)
    {
        if (currentLocation.QuestAvailableHere != null)
        {
            Quest localQuest = currentLocation.QuestAvailableHere;

            Console.WriteLine($"A quest is available: {localQuest.Name}");
            Console.WriteLine("Do you want to accept this quest? (Type 'accept' or 'decline')");

            string command = Console.ReadLine().ToLower();

            if (command == "accept")
            {
                Console.WriteLine("You accepted the quest!");
                Console.WriteLine($"Quest Details: {localQuest.Description}");
            }
            else if (command == "decline")
            {
                Console.WriteLine("You declined the quest. Maybe next time.");
            }
            else
            {
                Console.WriteLine("Invalid command. Please type 'accept' or 'decline'.");
            }
            
            Console.WriteLine(); 
        }
    }
}