namespace alpha;

class SuperAdventure
{
    public Monster CurrentMonster;
    public Player ThePlayer;

    public SuperAdventure(Monster CurrentMonsterValue, Player ThePlayerValue)
    {
        CurrentMonster = CurrentMonsterValue;
        ThePlayer = ThePlayerValue;
    }
}