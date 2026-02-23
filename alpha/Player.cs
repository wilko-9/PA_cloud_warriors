namespace alpha;

class Player
{
    public string Name;
    public int CurrentLocation;
    public int CurrentHitPoints;
    public int CurrentWeapon;
    public int MaximumHitPoints;

    public Player(string NameValue, int CurrentLocationValue,int CurrentWeaponValue, int CurrentHitPointsValue, int MaximumHitPointsValue)
    {
        Name = NameValue;
        CurrentLocation = CurrentLocationValue;
        CurrentWeapon = CurrentWeaponValue;
        CurrentHitPoints = CurrentHitPointsValue;
        MaximumHitPoints = MaximumHitPointsValue;
    }
}