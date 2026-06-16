namespace lecture12;

public class ArrayClass : IOutput2, ICalc2
{
    private int[] _numbers;

    public int[] Numbers
    {
        get { return _numbers;}
        set
        {
            if (value.Length > 0 && value != null)
            {
                _numbers = value;
                
            }
            else
            {
                Console.WriteLine("Array is empty");
                return;
            }
        }
    }
    
    public ArrayClass(int[] numbers)
    {
        _numbers = numbers;
    }
    
    
    public void ShowEven()
    {
        Console.WriteLine("Even numbers: ");
        foreach (var item in _numbers)
        {
            if (item % 2 == 0)
            {
                Console.Write(item + ",");
                
            }
        }
        Console.WriteLine();
    }
    
    public void ShowOdd()
    {
        Console.WriteLine("Odd numbers: ");
        
        foreach (var item in _numbers)
        {
            if (item % 2 != 0)
            {
                Console.Write(item + ",");
                
            }
        }
        Console.WriteLine();
    }

    // public int CountDinstinct()
    // {
    //     int count = 0;
    //     for (int i = 0; i < Numbers.Length; i++)
    //     {
    //         bool isDistinct = true;
    //
    //         for (int j = i + 1; j < Numbers.Length; j++)
    //         {
    //             if (Numbers[i] == Numbers[j])
    //             {
    //                 isDistinct = false;
    //                 break;
    //             }
    //         }
    //
    //         if (isDistinct)
    //         {
    //             count++;
    //         }
    //     }
    //     
    //     return count;
    // }

    public int CountDinstinct()
    {
        int count = 0;
        for (int i = 0; i < _numbers.Length; i++)
        {
            bool isDoublicate = false;

            for (int j = i + 1; j < _numbers.Length; j++)
            {
                if (Numbers[i] == Numbers[j])
                {
                    isDoublicate = true;
                    break;
                }
            }

            if (!isDoublicate)
            {
                count++;
            }
        }
        return count;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (var item in _numbers)
        {
            if (item == valueToCompare)
            {
                count++;
            }
        }
        
        return count;
    }
}