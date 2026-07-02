namespace lecture14;

public class Player
{
    string Name { get; set; }

    public Inventory[] Inventory;

    // public static Inventory[] Add(ref Inventory[] inventoryList, Inventory newInventory)
    // {
    //     int index = inventoryList.Length;
    //     Array.Resize(ref inventoryList, index + 1);
    //     inventoryList[index] = newInventory;
    //     return inventoryList;
    // }

}


public class Inventory
{
    public string Name { get; set; }
    public string Description { get; set; }
}