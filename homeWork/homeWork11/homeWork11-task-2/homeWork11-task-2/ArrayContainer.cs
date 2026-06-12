namespace homeWork11_task_2;

public class ArrayContainer
{

    private int[] _numbers;

    public int[] Numbers
    {
        get => _numbers;

        set
        {
            if (value == null || value.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty");
                return;
            }
            
            _numbers = value;
        }
    }

    public ArrayContainer(int[] numbers)
    {
        Numbers = numbers;
    }

    public int CountDistinct()
    {
        if (Numbers == null || Numbers.Length == 0)
            return 0;
        
        int count = 0;

        for (int i = 0; i < Numbers.Length; i++)
        {
            bool isUnique = true;
            
            for (int j = 0; j < i; j++)
            {
                if (Numbers[i] == Numbers[j])
                {
                    isUnique = false;
                    break;
                }
            }
            
            if(isUnique)
                count++;
        }
        return count;
    }


    public int EqualToValue(int valueToCompare)
    {
        if (Numbers == null || Numbers.Length == 0)
            return 0;
        
        int count = 0;

        foreach (int number in Numbers)
        {
            if (number == valueToCompare)
                count++;
        }
        return count;
    }


}