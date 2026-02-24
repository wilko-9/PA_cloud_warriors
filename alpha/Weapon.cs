namespace alpha;

class Weapon
{
    public int ID;
    public string Name;
    public int MaximumDamage;

    public Weapon(int idValue, string nameValue, int maximumDamageValue)
    {
        ID = idValue;
        Name = nameValue;
        MaximumDamage = maximumDamageValue;
    }
}
