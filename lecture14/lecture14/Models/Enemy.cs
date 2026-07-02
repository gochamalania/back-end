namespace lecture14;

public class Enemy
{
    string Name { get; set; }

    public Weapon[] Weapon;

    // public static Weapon[] Add(ref Weapon[] weaponList, Weapon newWeapon)
    // {
    //     int index = weaponList.Length;
    //     Array.Resize(ref weaponList, index + 1);
    //     weaponList[index] = newWeapon;
    //     return weaponList;
    // }

}

public class Weapon
{
    public string Name { get; set; }
    public int Damage { get; set; }
}