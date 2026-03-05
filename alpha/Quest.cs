namespace alpha;

public class Quest
{
    public string Description;
    public int ID;
    public string Name;

    public Quest(int IDValue, string DescriptionValue, string NameValue)
    {
        Description = DescriptionValue;
        ID = IDValue;
        Name = NameValue;
    }

    public void QuestCompleted(int currentWeaponID)
    {
        // Display quest completion message and reward
        Console.WriteLine("Congratulations! You have completed the quest: " + Name);
        Console.WriteLine("You have been rewarded a weapon upgrade: " + World.WeaponByID(currentWeaponID).Name);
    }

    public void AddWeaponReward(int weaponID)
    {
        // Implementation for adding weapon reward
        // Weapon reward logic can be implemented here: +1 on current weapon id.
    }
}