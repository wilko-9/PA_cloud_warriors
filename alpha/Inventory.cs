using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace alpha;

class Inventory
{
    public Dictionary<int,Item> InventoryItems = new Dictionary<int, Item>(); // id and object


    public Item? HoldingItem;

    public Inventory()
    {
        // 
    }

    public void add_to_InventoryItems(Item ItemObject)
    {
        int ItemID = ItemObject.ID; // we gebruiken hierzo inheritance, 
        // de baseclass is Item, maar we verwijzen naar bijv een weapon of potion ofzo
        InventoryItems.Add(ItemID, ItemObject);
    }

    public string show_InventoryItems()
    {
        string FullList = "";

        foreach ((int ItemID, Item ItemObject) in InventoryItems)
        {
            FullList += $"ItemID: {ItemID}; ItemName: {ItemObject.Name}\n";
        }

        return FullList;
    }

    public void SwitchItem(int? ItemID)
    {
        HoldingItem = ItemID != null && InventoryItems.TryGetValue(ItemID.Value, 
        out var item) ? item : null; // null betekent niks vasthouden 
    }
}