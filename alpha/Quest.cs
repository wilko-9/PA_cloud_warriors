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

    public void QuestCompleted(Inventory inventory, int currentWeaponID, string typeReward)
    {
        // Display quest completion message and reward
        Console.WriteLine("Congratulations! You have completed the quest: " + Name);
        if (typeReward == "WeaponUpgrade")
        {
            Console.WriteLine("You have been rewarded a weapon upgrade: " + World.WeaponByID(currentWeaponID).Name);
            inventory.UpgradeWeapon(currentWeaponID);
        }
    }
}