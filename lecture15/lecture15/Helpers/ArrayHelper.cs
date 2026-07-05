namespace lecture15.Helpers;

public class ArrayHelper
{
    public static void Add<T>(ref T[] arraylist, T newitem)
    {
        int index = arraylist.Length;
        Array.Resize(ref arraylist, index + 1);
        arraylist[index] = newitem;
    }
}