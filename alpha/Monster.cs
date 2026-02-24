namespace alpha;

class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public int CurrentHitPoints;
    public int MaximumHitPoints;

    public Monster(int id, string name, int damageValue, int currentHitPoints, int maximumHitPoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = damageValue;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }
}