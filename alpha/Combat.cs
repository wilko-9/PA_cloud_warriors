using System.Collections;

namespace alpha;

public class Combat
{
    Player PlayerCombat;
    Monster MonsterCombat;
    public Combat(Player player, Monster monster)
    {
        MonsterCombat = monster;
        PlayerCombat = player;
    }

    private void AskPlayer()
    {
        while (true)
        {
            Console.WriteLine("options: \n 1: attack");
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
                            default:
                                Console.WriteLine("please try again");
                                AskPlayer();
                                break;
                        }
                    }
                    if (result < 0)
                    {
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("please choose a number");
            }
        }
    }

    private void PlayerAttack()
    {
        MonsterCombat.CurrentHitPoints -= PlayerCombat.CurrentWeapon.MaximumDamage;
    }

    private void MonsterAttack()
    {
        PlayerCombat.CurrentHitPoints -= MonsterCombat.MaximumDamage;
    }

    public bool CombatMiniGamePlayerHasWon()
    {
        while (PlayerCombat.CurrentHitPoints > 0 && MonsterCombat.CurrentHitPoints > 0)
        {
            AskPlayer();
            if (MonsterCombat.CurrentHitPoints < 0)
            {
                return true;
            }
            MonsterAttack();
            if (PlayerCombat.CurrentHitPoints < 0)
            {
                return false;
            }
        }
        // if something goes wrong the player loses
        return false;
    }

}