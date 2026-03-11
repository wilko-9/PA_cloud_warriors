namespace alpha;
// logica voor quests te starten, kijkt naar locatie en geeft quest details als die er zijn.
public class start_quest
{
    public static void CheckForQuests(Location currentLocation, Weapon weapon, Player player)
    {
        if (currentLocation.QuestAvailableHere != null && !currentLocation.QuestAvailableHere.IsAccepted)
        {
            Quest localQuest = currentLocation.QuestAvailableHere;

            Console.WriteLine($"A quest is available: {localQuest.Name}");
            Console.WriteLine();
            Console.WriteLine("Do you want to accept this quest? (Type 'accept' or 'decline')");

            bool WrongAnswer;
            
            do
            {
                string? command = Console.ReadLine()?.ToLower();

                if (command == "accept")
                {
                    Console.Clear();
                    Console.WriteLine("You accepted the quest!");
                    Console.WriteLine($"Quest Details: {localQuest.Description}");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    localQuest.IsAccepted = true;
                    WrongAnswer = false;
                }
                else if (command == "decline")
                {
                    Console.Clear();
                    Console.WriteLine("You declined the quest. Maybe next time.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    WrongAnswer = false;
                }
                else
                {
                    Console.WriteLine("Invalid command. Please type 'accept' or 'decline'.");
                    WrongAnswer = true;
                }
            } while (WrongAnswer);
            
            Console.WriteLine(); 
        }
    }

    public static void CheckForCombat(Location currentLocation, Weapon weapon, Player player)
    {
        if (currentLocation.MonsterLivingHere != null)
        {
            foreach (Quest quest in World.Quests)
            {
                if (quest.IsAccepted && !quest.IsCompleted)
                {
                    quest.StartQuest(weapon, player, currentLocation);
                    break;
                }
            }
        }
    }
}