namespace alpha;

public class Weapon
{
     public int ID;
     public string Name;
    public int MaximumDamage;

    public int WeaponLevel = 1;

    public static readonly Dictionary<int, string> UpgradeLevels = new Dictionary<int, string>
    {
        [1] = "wood",
        [2] = "iron",
        [3] = "diamond"
    };

    public Weapon(int id, string name, int maximumDamage)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
    }

    public void UpgradeWeaponLevel()
    {
        WeaponLevel += 1;
    }
}
