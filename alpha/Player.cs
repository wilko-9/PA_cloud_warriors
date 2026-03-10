namespace alpha;

public class Player
{
    public string Name;
    public int CurrentLocation;
    public int CurrentHitPoints;
    public Weapon CurrentWeapon;
    public int MaximumHitPoints;

    public Player(string name, int currentLocation, Weapon currentWeapon, int currentHitPoints, int maximumHitPoints)
    {
        Name = name;
        CurrentLocation = currentLocation;
        CurrentWeapon = currentWeapon;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }
}