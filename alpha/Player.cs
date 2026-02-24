namespace alpha;

class Player
{
    public string Name;
    public int CurrentLocation;
    public int CurrentHitPoints;
    public int CurrentWeapon;
    public int MaximumHitPoints;

    public Player(string name, int currentLocation,int currentWeapon, int currentHitPoints, int maximumHitPoints)
    {
        Name = name;
        CurrentLocation = currentLocation;
        CurrentWeapon = currentWeapon;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }
}