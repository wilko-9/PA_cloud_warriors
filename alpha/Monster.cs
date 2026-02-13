namespace alpha;

class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public int CurrentHitPoints;
    public int MaximumHitPoints;

    public Monster(int IDValue, string NameValue, int MaximumDamageValue, int CurrentHitPointsValue, int MaximumHitPointsValue)
    {
        ID = IDValue;
        Name = NameValue;
        MaximumDamage = MaximumDamageValue;
        CurrentHitPoints = CurrentHitPointsValue;
        MaximumHitPoints = MaximumHitPointsValue;
    }
}