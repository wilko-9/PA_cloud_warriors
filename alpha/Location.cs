namespace alpha;
class Location
{
    public int ID;
    public string Name;
    public string Description;
    public string Unkown;
    public string UnkownTwo;


    //TODO: Ask what the unknown values are supposed to be and what they are supposed to track
    public Location(int IDValue, string NameValue, string DescriptionValue, string UnkownValue, string UnkownValueTwo)
    {
        ID = IDValue;
        Name = NameValue;
        Description = DescriptionValue;
        Unkown = UnkownValue;
        UnkownTwo = UnkownValueTwo;
    }
}