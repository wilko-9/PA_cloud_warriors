namespace alpha;

class Quest
{
    public string Description;
    public int ID;
    public string Name;

    public Quest(string DescriptionValue, int IDValue, string NameValue)
    {
        Description = DescriptionValue;
        ID = IDValue;
        Name = NameValue;
    }
}