namespace alpha;

public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Quest QuestAvailableHere;
    public Monster? MonsterLivingHere;
    public Location? LocationToNorth;
    public Location? LocationToEast;
    public Location? LocationToSouth;
    public Location? LocationToWest;

    public Location(
        int IDValue,
        string NameValue,
        string DescriptionValue,
        Quest questAvailableHere,
        Monster? monsterLivingHere = null,
        Location? locationToNorth = null,
        Location? locationToEast = null,
        Location? locationToSouth = null,
        Location? locationToWest = null
    )
    {
        ID = IDValue;
        Name = NameValue;
        Description = DescriptionValue;
        QuestAvailableHere = questAvailableHere;
        MonsterLivingHere = monsterLivingHere;
        LocationToNorth = locationToNorth;
        LocationToEast = locationToEast;
        LocationToSouth = locationToSouth;
        LocationToWest = locationToWest;
    }
}