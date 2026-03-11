namespace alpha;

public class Combat
{
    Player PlayerCombat;
    Monster MonsterCombat;
    bool CanFlee;
    bool PlayerFled;
    public Combat(Player player, Monster monster, bool canFlee = false)
    {
        MonsterCombat = monster;
        PlayerCombat = player;
        CanFlee = canFlee;
        PlayerFled = false;
    }

    private void ShowCombatStatus()
    {
        Console.Clear();
        Console.WriteLine("--- COMBAT ---");
        Console.WriteLine();
        Console.WriteLine($"  {PlayerCombat.Name,-15} {PlayerCombat.CurrentHitPoints}/{PlayerCombat.MaximumHitPoints} HP");
        Console.WriteLine($"  {MonsterCombat.Name,-15} {MonsterCombat.CurrentHitPoints}/{MonsterCombat.MaximumHitPoints} HP");
        Console.WriteLine();
    }

    private void AskPlayer()
    {
        Console.WriteLine("What will you do?");
        Console.WriteLine("  1: Attack");
        if (CanFlee) Console.WriteLine("  2: Flee");
        Console.WriteLine();
        Console.Write("> ");
        string? option = Console.ReadLine();
        if (option is not null)
        {
            if (int.TryParse(option, out int result))
            {
                if (result > 0)
                {
                    switch (result)
                    {
                        case 1:
                            PlayerAttack();
                            break;
                        case 2:
                            if (CanFlee)
                            {
                                PlayerFled = true;
                            }
                            else
                            {
                                Console.WriteLine("You can't flee!");
                                Console.ReadKey();
                                AskPlayer();
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid option, try again.");
                            Console.ReadKey();
                            AskPlayer();
                            break;
                    }
                }
                if (result < 0)
                {
                   AskPlayer();
                }
            }
        }
        else
        {
            Console.WriteLine("Please choose a number.");
            Console.ReadKey();
        }
    }

    private void PlayerAttack()
    {
        MonsterCombat.CurrentHitPoints -= PlayerCombat.CurrentWeapon.MaximumDamage;
        if (MonsterCombat.CurrentHitPoints < 0) MonsterCombat.CurrentHitPoints = 0;
    }

    private void MonsterAttack()
    {
        PlayerCombat.CurrentHitPoints -= MonsterCombat.MaximumDamage;
        if (PlayerCombat.CurrentHitPoints < 0) PlayerCombat.CurrentHitPoints = 0;
    }

    public bool? CombatMiniGamePlayerHasWon()
    {
        while (PlayerCombat.CurrentHitPoints > 0 && MonsterCombat.CurrentHitPoints > 0)
        {
            ShowCombatStatus();
            AskPlayer();
            if (PlayerFled)
            {
                return null;
            }
            if (MonsterCombat.CurrentHitPoints <= 0)
            {
                ShowCombatStatus();
                return true;
            }
            MonsterAttack();
            if (PlayerCombat.CurrentHitPoints <= 0)
            {
                ShowCombatStatus();
                return false;
            }
        }
        return false;
    }

}