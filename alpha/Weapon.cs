namespace alpha;

class Weapon
{
    public int ID;
    public string Name;
    public int MaximumDamage;

    public Weapon(int IDValue, string NameValue, int MaximumDamageValue)
    {
        ID = IDValue;
        Name = NameValue;
        MaximumDamage = MaximumDamageValue;
        CurrentHitPoints = CurrentHitPointsValue;
        MaximumHitPoints = MaximumHitPointsValue;
    }
}
