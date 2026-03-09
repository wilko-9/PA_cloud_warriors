using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;

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

    public void QuestCompleted(Weapon weapon, string typeReward) {
        Console.WriteLine("Congratulations! You have completed the quest: " + Name);
        if (typeReward == "WeaponUpgrade") {
            string currentState = Weapon.UpgradeLevels[weapon.WeaponLevel];
            weapon.UpgradeWeaponLevel();
            string nextState = Weapon.UpgradeLevels[weapon.WeaponLevel];
            Console.WriteLine("Your " + currentState + " " + weapon.Name + " is upgraded to a " + nextState + " " + weapon.Name);
        }
    }
}