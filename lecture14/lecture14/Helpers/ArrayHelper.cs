namespace lecture14.Helpers;

public class ArrayHealper
{
    public static T[] Add<T>( ref T[] inventoryList, T newInventory)
    {
        int index = inventoryList.Length;
        Array.Resize(ref inventoryList, index + 1);
        inventoryList[index] = newInventory;
        return inventoryList;
    }
}