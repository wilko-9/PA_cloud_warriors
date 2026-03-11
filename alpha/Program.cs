namespace alpha;

class Program
{
    static bool GameRunning = true;
    static void Main(string[] args)
    {
        
        Weapon Sword = new Weapon(0, "Sword", 2);
        Player player = new Player("Player", 1, Sword, 10, 10);
        
        while (GameRunning)
        {
            MoveLocation.Move_Location_Loop(Sword, player);
            // wanneer speler pas zegt ik wil nie meer bewegen gaan we verder

            // logica ShowLocation
        }

    }

    public static void exit_game()
    {
        Console.WriteLine("Thanks for playing! Goodbye!");
        GameRunning = false;
    }

    static private void start_game()
    {
        //
        
    }

    
}