namespace alpha;

public class Quest
{
    public string Description;
    public int ID;
    public string Name;
    public bool IsAccepted;
    public bool IsCompleted;

    private int MonstersRemaining = 3;

    public Quest(int IDValue, string DescriptionValue, string NameValue)
    {
        Description = DescriptionValue;
        ID = IDValue;
        Name = NameValue;
    }
    
    public void StartQuest(Weapon weapon, Player player, Location currentLocation)
    {
        Monster? monster = currentLocation.MonsterLivingHere;
        if (monster == null) return;

        Console.Clear();
        Console.WriteLine($"Quest started: {Name}");
        Console.WriteLine($"Defeat {MonstersRemaining} {monster.Name}(s)!");
        Console.WriteLine();
        Console.WriteLine("Press any key to begin...");
        Console.ReadKey();

        while (MonstersRemaining > 0)
        {
            Monster fightMonster = new Monster(monster.ID, monster.Name, monster.MaximumDamage, monster.MaximumHitPoints, monster.MaximumHitPoints);
            player.CurrentHitPoints = player.MaximumHitPoints;

            Console.Clear();
            Console.WriteLine($"--- {monster.Name} | {MonstersRemaining} remaining ---");

            Combat combat = new Combat(player, fightMonster, canFlee: true);
            bool? result = combat.CombatMiniGamePlayerHasWon();

            if (result == true)
            {
                MonstersRemaining--;
                Console.Clear();
                Console.WriteLine($"You defeated the {monster.Name}!");
                Console.WriteLine($"{MonstersRemaining} remaining");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else if (result == null)
            {
                Console.Clear();
                Console.WriteLine("You fled from the fight!");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                player.CurrentHitPoints = player.MaximumHitPoints;
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You were defeated! Try again next time...");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                player.CurrentHitPoints = player.MaximumHitPoints;
                return;
            }
        }

        Console.Clear();
        currentLocation.MonsterLivingHere = null;
        QuestCompleted(weapon, "WeaponUpgrade");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void QuestCompleted(Weapon weapon, string typeReward) {
        Console.WriteLine("Congratulations! You have completed the quest: " + Name);
        if (typeReward == "WeaponUpgrade") {
            string currentState = Weapon.UpgradeLevels[weapon.WeaponLevel];
            weapon.UpgradeWeaponLevel();
            string nextState = Weapon.UpgradeLevels[weapon.WeaponLevel];
            Console.WriteLine("Your " + currentState + " " + weapon.Name + " is upgraded to a " + nextState + " " + weapon.Name);
        }
        IsCompleted = true;
    }
}